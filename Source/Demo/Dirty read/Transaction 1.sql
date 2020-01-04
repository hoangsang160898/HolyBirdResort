BEGIN TRAN
	exec usp_TraCuuPhong N'1',N'Trống',N'2 giường đơn',N'Thường'
COMMIT TRAN

select * from Phong