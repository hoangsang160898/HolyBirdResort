BEGIN TRAN
	exec sp_TraPhong 3
	exec sp_TraPhong 4
	waitfor delay '00:00:05'
COMMIT TRAN 

select * from ChiTietGiaoDich