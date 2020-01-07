use HolyBird
go

-- Huy Giao Dich
CREATE PROCEDURE usp_NhanPhong
	 @MaDoan varchar(10)
as
begin tran
	declare @MaGiaoDich int = (select ID from GiaoDich where MaDoan = @MaDoan)
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	declare @DanhSachPhong table (ID int)

	insert into @DanhSachPhong
	select ID_Phong from ChiTietGiaoDich where ID_GiaoDich = @MaGiaoDich
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	update Phong set TrangThai = N'Đang sử dụng' where ID in (select * from @DanhSachPhong)
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end
	
	update GiaoDich set IsActive = 1 where ID = @MaGiaoDich
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

commit tran
go

exec usp_NhanPhong 'D001'

select * from GiaoDich where ID > 5
select * from ChiTietGiaoDich where ID > 10
select * from Phong where ID = 1 or ID = 2 or ID = 3
select * from TaiKhoan where ID > 5