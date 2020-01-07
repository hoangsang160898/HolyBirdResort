--Tạo Database
CREATE DATABASE HolyBird
GO

USE HolyBird
GO

--Tạo bảng
CREATE TABLE GiaoDich 
(
	ID INT PRIMARY KEY identity(1,1),
	MaDoan VARCHAR(10),
	ID_DaiDien INT,
	SoNguoi INT,
	SoPhong INT,
	NgayBatDau DATE,
	NgayKetThuc DATE,
	TONGTIEN VARCHAR(20),
    IsActive BIT
)
GO

CREATE TABLE ChiTietGiaoDich
(
	ID INT PRIMARY KEY identity(1,1),
	ID_GiaoDich INT,
	ID_KhachHang INT,
	ID_Phong INT,
	NgayBatDau DATE,
	NgayKetThuc DATE,
	ThanhTien VARCHAR(20),
)
GO

CREATE TABLE KhachHang
(
	ID INT PRIMARY KEY identity(1,1),
	HoTen NVARCHAR(50),
	CMND VARCHAR(10),
)
GO

CREATE TABLE TaiKhoan
(
	ID INT PRIMARY KEY identity(1,1),
	TenDangNhap VARCHAR(20),
	MatKhau VARCHAR(20),
	ID_GiaoDich INT,
)

CREATE TABLE ThietHai
(
	ID INT PRIMARY KEY identity(1,1),
    ID_Phong INT,
    TaiSanThietHai NVARCHAR(50),
    ChiPhiDenBu VARCHAR(20),
    ID_GiaoDich INT,
)
GO

CREATE TABLE Phong
(
	ID INT PRIMARY KEY identity(1,1),
	SoTang INT,
    Gia VARCHAR(20),
    TrangThai NVARCHAR(20),
    HinhThuc NVARCHAR(20),
    HangPhong NVARCHAR(20),
)
GO

CREATE TABLE NhanVien
(
	ID INT PRIMARY KEY identity(1,1),
    TenNhanVien NVARCHAR(20),
    TenDangNhap NVARCHAR(20),
    MatKhau VARCHAR(20),
    
)
GO

--Tạo khóa ngoại cho các bảng
ALTER TABLE dbo.ChiTietGiaoDich ADD CONSTRAINT FK_ChiTietGiaoDich_GiaoDich FOREIGN KEY(ID_GiaoDich)
REFERENCES dbo.GiaoDich(ID)
GO

ALTER TABLE dbo.ChiTietGiaoDich ADD CONSTRAINT FK_ChiTietGiaoDich_KhachHang FOREIGN KEY(ID_KhachHang)
REFERENCES dbo.KhachHang (ID)
GO

ALTER TABLE dbo.ChiTietGiaoDich ADD CONSTRAINT FK_ChiTietGiaoDich_Phong FOREIGN KEY(ID_Phong)
REFERENCES dbo.Phong (ID)
GO

ALTER TABLE dbo.GiaoDich ADD CONSTRAINT FK_GiaoDich_KhachHang FOREIGN KEY(ID_DaiDien)
REFERENCES dbo.KhachHang (ID)
GO

ALTER TABLE dbo.TaiKhoan ADD CONSTRAINT FK_TaiKhoan_GiaoDich FOREIGN KEY(ID_GiaoDich)
REFERENCES dbo.GiaoDich (ID)
GO

ALTER TABLE dbo.ThietHai ADD CONSTRAINT FK_ThietHai_GiaoDich FOREIGN KEY(ID_GiaoDich)
REFERENCES dbo.GiaoDich (ID)
GO

ALTER TABLE dbo.ThietHai ADD CONSTRAINT FK_ThietHai_Phong FOREIGN KEY(ID_Phong)
REFERENCES dbo.Phong (ID)
GO

-- Chèn dữ liệu bảng Phong
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (1,'100000',N'Trống',N'1 giường đơn',N'Thường')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (1,'200000',N'Trống',N'2 giường đơn',N'Thường')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (1,'250000',N'Trống',N'1 giường đôi',N'Sang')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (2,'300000',N'Trống',N'2 giường đơn',N'Sang')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (2,'350000',N'Trống',N'1 giường đôi',N'VIP')

--Chèn dữ liệu bảng NhanVien
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien1','NhanVien1','123456')