-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_CapNhatThietHai
	@MaPhongThietHai INT,
	@MaGiaoDichThietHai INT,
	@TenThietHai NVARCHAR(50),
	@ChiPhiThietHai VARCHAR(20)
AS
BEGIN
	BEGIN TRAN
		INSERT INTO ThietHai(ID_Phong,TaiSanThietHai,ChiPhiDenBu,ID_GiaoDich)
		VALUES(
		@MaPhongThietHai,
		@TenThietHai,
		@ChiPhiThietHai,
		@MaGiaoDichThietHai
		)
		IF(@@ERROR<>0)
		BEGIN
			ROLLBACK TRAN
			RETURN
		END
	COMMIT TRAN
END
GO
