use HolyBird
go

-- Tra cuu phong
CREATE PROCEDURE usp_TraCuuPhong
	 @SoTang int, @TrangThai nvarchar(20), @HinhThuc nvarchar(20), @HangPhong nvarchar(20)
as
begin tran
	Declare @SqlQuery as nvarchar(4000)
	DECLARE @ParamDefinition AS NVARCHAR(2000) 

	Set @SqlQuery = 'select * from Phong where (1=1) '

	if @SoTang is not null
		set @SqlQuery = @SqlQuery + ' and SoTang = @SoTang '
	if @TrangThai is not null
		set @SqlQuery = @SqlQuery + ' and TrangThai = @TrangThai '
	if @HinhThuc is not null
		set @SqlQuery = @SqlQuery + ' and HinhThuc = @HinhThuc '
	if @HangPhong is not null
		set @SqlQuery = @SqlQuery + ' and HangPhong = @HangPhong '

	SET @ParamDefinition = '@SoTang int,
                            @TrangThai nvarchar(20),
							@HinhThuc nvarchar(20), 
							@HangPhong nvarchar(20)'
	

	execute sp_Executesql @SqlQuery, @ParamDefinition,@SoTang,@TrangThai,@HinhThuc,@HangPhong
		Waitfor delay '00:00:05'
	execute sp_Executesql @SqlQuery, @ParamDefinition,@SoTang,@TrangThai,@HinhThuc,@HangPhong
	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end
	
commit tran
go

exec usp_TraCuuPhong null,N'Trống',null,null

