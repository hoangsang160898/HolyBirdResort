SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

--CREATE TYPE ThietHaiPhongTemp AS TABLE(
--	IDPhong INT, ChiPhiDenBu INT, ID_GiaoDich INT
--)
--GO

CREATE PROCEDURE Sp_TraPhong
	--@ThietHaiPhong as ThietHaiPhongTemp READONLY,
	@MaChiTietGiaoDich INT
AS
BEGIN
	BEGIN TRAN
		DECLARE @NgayBatDauGD DATE
		DECLARE @NgayKetThucGD DATE
		DECLARE @MaPhongGD INT
		DECLARE @TrangThaiPhongGDCanDoi NVARCHAR(20)
		DECLARE @MaGiaodich INT
		DECLARE @SLChiTietGiaoDich INT
		BEGIN

			SET @MaGiaodich = (SELECT ID_GiaoDich 
								FROM dbo.ChiTietGiaoDich
								WHERE ID = @MaChiTietGiaoDich)
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END

			SET @TrangThaiPhongGDCanDoi = N'Trống'

			SET @MaPhongGD = (SELECT ID_Phong
								FROM ChiTietGiaoDich
								WHERE ID = @MaChiTietGiaoDich)
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END

			DECLARE @TrangThaiPhongGDHienTai NVARCHAR(20)
			SET @TrangThaiPhongGDHienTai = (SELECT TrangThai 
											FROM Phong
											WHERE ID=@MaPhongGD) 
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END
			IF(@TrangThaiPhongGDHienTai!=N'Đang sử dụng')
			BEGIN
				ROLLBACK TRAN
				RETURN
			END

			DECLARE @SLChiTietGiaoDichPhong INT
			SET @SLChiTietGiaoDichPhong = ( SELECT COUNT(*)
											FROM dbo.ChiTietGiaoDich
											WHERE ID_GiaoDich = @MaGiaoDich and ID_Phong=@MaPhongGD)
			IF(@SLChiTietGiaoDichPhong = 1)
			BEGIN
				UPDATE dbo.PHONG
				SET TrangThai = @TrangThaiPhongGDCanDoi WHERE ID = @MaPhongGD
				IF(@@ERROR<>0)
				BEGIN
					ROLLBACK TRAN
					RETURN
				END
			END
			
			DELETE dbo.ChiTietGiaoDich WHERE ID = @MaChiTietGiaoDich
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END

			SET @SLChiTietGiaoDich = ( SELECT COUNT(*)
											FROM dbo.ChiTietGiaoDich
											WHERE ID_GiaoDich = @MaGiaoDich)
			IF(@@ERROR<>0)
			BEGIN
				ROLLBACK TRAN
				RETURN
			END
			IF (@SLChiTietGiaoDich = 0)
			BEGIN
				DELETE dbo.TaiKhoan WHERE ID_GiaoDich = @MaGiaoDich
				IF(@@ERROR<>0)
				BEGIN
					ROLLBACK TRAN
					RETURN
				END

				DELETE dbo.ThietHai WHERE ID_GiaoDich = @MaGiaodich
				IF(@@ERROR<>0)
				BEGIN
					ROLLBACK TRAN
					RETURN
				END

				UPDATE dbo.GiaoDich
				SET IsActive = 0
				WHERE ID = @MaGiaoDich
				IF(@@ERROR<>0)
				BEGIN
					ROLLBACK TRAN
					RETURN
				END
			END
		END
	COMMIT TRAN
END
GO