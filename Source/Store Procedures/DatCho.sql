use HolyBird
go

-- Đặt chỗ
create Type DatChoTemp as table (
	MaKhachHang int, MaPhong int, NgayBatDau date, NgayKetThuc date 
)
go
Create procedure usp_DatCho
	@DanhSachDatCho as DatChoTemp readonly,@MaDoan varchar(10)
as
begin
begin tran
	Declare @MaKhachHang int, @MaPhong int, @NgayBatDau date, @NgayKetThuc date
	Declare @TableDatChoUnit table (MaKhachHang int, MaPhong int, NgayBatDau date, NgayKetThuc date )
	Declare @minDate date, @maxDate date
	Declare @SoPhong int, @datediff int, @TienPhong int

	select @minDate = NgayBatDau, @maxDate = NgayKetThuc from GiaoDich where MaDoan = @MaDoan

	select @SoPhong = count(Distinct MaPhong) from @DanhSachDatCho
	declare @SoPhongGoc int = (select SoPhong from GiaoDich with (nolock) where MaDoan = @MaDoan)

	update GiaoDich set SoPhong = @SoPhongGoc + @SoPhong where MaDoan = @MaDoan
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	insert into @TableDatChoUnit select * from @DanhSachDatCho
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	while 1 = 1
	begin
		SET @MaKhachHang = NULL
        SELECT TOP(1) @MaKhachHang = MaKhachHang, @MaPhong = MaPhong, @NgayBatDau = NgayBatDau, @NgayKetThuc = NgayKetThuc
        FROM @TableDatChoUnit

        IF @MaKhachHang IS NULL
            BREAK

		if (@NgayBatDau > @NgayKetThuc)
		begin
			raiserror('Ngày bắt đầu không được lớn hơn ngày kết thúc',1,1)
			rollback tran
			return
		end

		if (@NgayBatDau < @minDate) or (@NgayBatDau > @maxDate) 
		begin
			raiserror('Ngày bắt đầu không nằm trong khoảng thời gian cho phép',1,1)
			rollback tran
			return
		end

		if (@NgayKetThuc < @minDate) or (@NgayKetThuc > @maxDate)
		begin
			raiserror('Ngày kết thúc không nằm trong khoảng thời gian cho phép',1,1)
			rollback tran
			return
		end
		
		set @datediff = datediff(day,@NgayBatDau,@NgayKetThuc)
		if @datediff = 0
		begin
			set @datediff = 1
		end

		set @TienPhong = (select convert(int,Gia) from Phong where ID = @MaPhong)

		declare @TongTien int = @TienPhong * @datediff

		update ChiTietGiaoDich Set ID_Phong = @MaPhong,NgayBatDau = @NgayBatDau,NgayKetThuc = @NgayKetThuc, ThanhTien = convert(varchar(20),@TongTien)
		where ID_KhachHang = @MaKhachHang
		if(@@ERROR <> 0)
		begin
			rollback tran
			return
		end

		update Phong set TrangThai = N'Đặt trước' where @MaPhong = ID
		if(@@ERROR <> 0)
		begin
			rollback tran
			return
		end

        DELETE TOP(1) FROM @TableDatChoUnit
		if(@@ERROR <> 0)
		begin
			rollback tran
			return
		end
	end

commit tran
end
go

declare @temp DatChoTemp;
insert into @temp (MaKhachHang,MaPhong,NgayBatDau,NgayKetThuc) values (26,1,'2020-01-02','2020-01-02'),(27,2,'2020-01-02','2020-01-02'),(28,3,'2020-01-02','2020-01-02')

execute usp_DatCho @temp, 'D001'

go

select * from GiaoDich where ID > 5
select * from ChiTietGiaoDich where ID > 10
select * from Phong where ID = 1 or ID = 2 or ID =3
select * from KhachHang where ID > 10
