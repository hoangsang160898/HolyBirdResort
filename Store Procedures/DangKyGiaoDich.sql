use HolyBird
go

create Type CustomerType as table(
	Name NVARCHAR(50),
	IdCard VARCHAR(10)
)
go

alter proc usp_DangKyGiaoDich
	@MaDoan VARCHAR(10), @DanhSachKhachHang as CustomerType readonly, @NgayBatDau date, @NgayKetThuc date
as
begin
	if @NgayBatDau > @NgayKetThuc
	begin
		raiserror('Ngày bắt đầu không được lớn hơn ngày kết thúc',1,1)
		return
	end
begin tran
	--set transaction isolation level read uncommitted
	Declare @SoNguoi int, @MaDaiDien int, @CmndDaiDien varchar(10)
	Declare @TableKhachHang table (ID int)
	Declare @TableGiaoDich table (ID int)
	Declare @MaGiaoDich int, @TenDangNhap varchar(20), @Matkhau varchar(20) 

	set @SoNguoi = (select count(*) from @DanhSachKhachHang)

	set @CmndDaiDien = (Select top 1 IdCard from @DanhSachKhachHang)

	insert into @TableKhachHang select ID from KhachHang where CMND in (Select IdCard from @DanhSachKhachHang)

	-- Them khach hang
	insert into KhachHang(HoTen,CMND)
	output inserted.ID into @TableKhachHang 
	select * from @DanhSachKhachHang where not exists (select * from KhachHang where IdCard = CMND)

	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	set @MaDaiDien = (select  ID from KhachHang where CMND = @CmndDaiDien)

	-- Them giao dich
	insert into GiaoDich(MaDoan,ID_DaiDien,SoNguoi,NgayBatDau,NgayKetThuc) 
	output inserted.ID into @TableGiaoDich
	values(@MaDoan,@MaDaiDien,@SoNguoi,@NgayBatDau,@NgayKetThuc)

	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	-- them chi tiet giao dich
	insert into ChiTietGiaoDich(ID_KhachHang)
	select ID from @TableKhachHang

	set @MaGiaoDich = (select top 1 ID from @TableGiaoDich)
	
	-- cap nhat ma giao dich cua cac chi tiet giao dich
	update ChiTietGiaoDich set ID_GiaoDich = @MaGiaoDich where ID_KhachHang in (select ID from @TableKhachHang)
	
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end
	
	select top 1 @TenDangNhap = IdCard,@MatKhau = Name from @DanhSachKhachHang
	
	insert into TaiKhoan(TenDangNhap,MatKhau,ID_GiaoDich) values (@TenDangNhap,@Matkhau,@MaGiaoDich) 

	select TenDangNhap,MatKhau from TaiKhoan where ID_GiaoDich = @MaGiaoDich

commit tran
end
go

declare @customerlist CustomerType;
insert into @customerlist (Name,IdCard) values ('Phong_1',1), ('Phong_2',2),('Phong_3',3)

execute usp_DangKyGiaoDich @MaDoan = 'D001', @DanhSachKhachHang = @customerlist, @NgayBatDau = '2020-01-02', @NgayKetThuc = '2020-01-02'

go

/*
select * from KhachHang where ID > 10
select * from GiaoDich where ID > 5
select * from ChiTietGiaoDich where ID > 10
select * from TaiKhoan where ID > 5

delete from TaiKhoan where ID > 5
delete from ChiTietGiaoDich where ID > 10
delete from GiaoDich where ID > 5
delete from KhachHang where ID > 28 
*/

