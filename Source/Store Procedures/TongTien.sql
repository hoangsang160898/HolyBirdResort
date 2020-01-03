SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_TongTien
	@MaGiaoDich INT
AS
BEGIN
	BEGIN TRAN
		DECLARE @TongTienGiaoDich INT
		BEGIN
			SET @TongTienGiaoDich = (SELECT SUM(CAST(ThanhTien AS FLOAT) + CAST(ChiPhiDenBu AS FLOAT)) 
									FROM dbo.ChiTietGiaoDich CTGD, dbo.ThietHai TH
									WHERE CTGD.ID_GiaoDich = @MaGiaoDich and TH.ID_GiaoDich=@MaGiaoDich)
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END

			UPDATE dbo.GiaoDich
			SET TONGTIEN=@TongTienGiaoDich
			WHERE ID = @MaGiaoDich
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END
		END
	COMMIT TRAN
END
GO
