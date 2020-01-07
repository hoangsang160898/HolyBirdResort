use HolyBird
go

-- Huy Giao Dich
alter proc usp_HuyGiaoDich
	 @MaGiaoDich int
as
begin tran
	delete from TaiKhoan where ID_GiaoDich = @MaGiaoDich
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	declare @MaPhongList table (ID int) 
	
	insert into @MaPhongList
	select ID_Phong from ChiTietGiaoDich where @MaGiaoDich = ID_GiaoDich
	
	update Phong set TrangThai = N'Trống' where ID in (select * from @MaPhongList)
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end

	DELETE FROM ChiTietGiaoDich where ID_GiaoDich = @MaGiaoDich
	if(@@ERROR <> 0)
		begin
			rollback tran
			return
	end

	delete from GiaoDich where ID = @MaGiaoDich
	
commit tran
go

exec usp_HuyGiaoDich 13

select * from GiaoDich where ID > 5
select * from ChiTietGiaoDich where ID > 10
select * from Phong where ID = 1 or ID = 2 or ID = 3
select * from TaiKhoan where ID > 5