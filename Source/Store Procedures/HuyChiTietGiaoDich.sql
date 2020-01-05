use HolyBird
go

-- Huy chi tiet Giao Dich
alter proc usp_HuyChiTietGiaoDich
	@MaChiTietGiaoDich int, @MaGiaoDich int
as
begin tran
	
	declare @MaPhong int = (select ID_Phong from ChiTietGiaoDich where @MaChiTietGiaoDich = ID)

	DELETE FROM ChiTietGiaoDich where ID = @MaChiTietGiaoDich
	if(@@ERROR <> 0)
		begin
			rollback tran
			return
	end

	if not exists (select * from ChiTietGiaoDich where ID_GiaoDich = @MaGiaoDich and ID_Phong = @MaPhong)
	begin
		update Phong set TrangThai = N'Trống' where @MaPhong = ID
		if(@@ERROR <> 0)
		begin
			rollback tran
			return
		end
	end
	

	if not exists (select * from ChiTietGiaoDich where ID_GiaoDich = @MaGiaoDich) 
	begin
			delete from ThietHai where ID_GiaoDich = @MaGiaoDich
		delete from TaiKhoan where ID_GiaoDich = @MaGiaoDich
		if(@@ERROR <> 0)
		begin
			rollback tran
			return
		end

		delete from GiaoDich where ID = @MaGiaoDich
		if(@@ERROR <> 0)
		begin
			rollback tran
			return
		end


	end
commit tran
go

exec usp_HuyChiTietGiaoDich 1,2

go

select * from GiaoDich where ID > 5
select * from ChiTietGiaoDich where ID > 10
select * from Phong where ID = 1 or ID = 2 or ID = 3
select * from TaiKhoan where ID > 5