use HolyBird
go

-- Tra cuu giao dich
create procedure usp_TraCuuGiaoDich
	 @MaDoan varchar(10),@IsActive bit,@minDate date, @maxDate date
as
begin tran
	Declare @SqlQuery as nvarchar(4000)
	DECLARE @ParamDefinition AS NVARCHAR(2000) 

	Set @SqlQuery = 'select * from GiaoDich where (1=1) '

	if @MaDoan is not null
		set @SqlQuery = @SqlQuery + ' and MaDoan = @MaDoan '
	if @IsActive is not null
		set @SqlQuery = @SqlQuery + ' and IsActive = @IsActive '
	if @minDate is not null
		set @SqlQuery = @SqlQuery + ' and datediff(day,NgayBatDau,@minDate) >= 0 '
	if @maxDate is not null
		set @SqlQuery = @SqlQuery + ' and datediff(day,NgayKetThuc,@maxDate) <= 0 '

	SET @ParamDefinition = '@MaDoan varchar(10),
							@IsActive bit,
							@minDate date, 
							@maxDate date'
	
	execute sp_Executesql @SqlQuery, @ParamDefinition,@MaDoan,@IsActive,@minDate, @maxDate

	if(@@ERROR <> 0)
	begin
		rollback tran
		return
	end
	
commit tran
go

exec usp_TraCuuGiaoDich N'DA007','True', N'2020-01-07',N'2020-01-08'

select * from GiaoDich
