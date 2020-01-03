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

-- Chèn dữ liệu bảng KhachHang
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang1','1234567890')
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang2','1234567890') 
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang3','1234567890') 
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang4','1234567890') 
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang5','1234567890')
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang6','1234567890')
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang7','1234567890')
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang8','1234567890')
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang9','1234567890')
INSERT INTO KhachHang(HoTen,CMND) VALUES (N'KhachHang10','1234567890') 

-- Chèn dữ liệu bảng Phong
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (1,'100000',N'Trống',N'1 giường đơn',N'Thường')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (1,'200000',N'Trống',N'2 giường đơn',N'Thường')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (1,'250000',N'Trống',N'1 giường đôi',N'Sang')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (2,'300000',N'Trống',N'2 giường đơn',N'Sang')
INSERT INTO Phong(SoTang,Gia,TrangThai,HinhThuc,HangPhong) VALUES (2,'350000',N'Trống',N'1 giường đôi',N'VIP')

-- Chèn dữ liệu bảng GiaoDich
INSERT INTO GiaoDich(MaDoan,ID_DaiDien,SoNguoi,SoPhong,NgayBatDau,NgayKetThuc,TongTien,IsActive) VALUES ('MD1',1,2,1,'2019-01-13','2019-01-03','200000','True')
INSERT INTO GiaoDich(MaDoan,ID_DaiDien,SoNguoi,SoPhong,NgayBatDau,NgayKetThuc,TongTien,IsActive) VALUES ('MD2',2,2,1,'2019-01-13','2019-01-03','400000','False')
INSERT INTO GiaoDich(MaDoan,ID_DaiDien,SoNguoi,SoPhong,NgayBatDau,NgayKetThuc,TongTien,IsActive) VALUES ('MD3',3,2,1,'2019-01-13','2019-01-03','500000','False')
INSERT INTO GiaoDich(MaDoan,ID_DaiDien,SoNguoi,SoPhong,NgayBatDau,NgayKetThuc,TongTien,IsActive) VALUES ('MD4',4,2,1,'2019-01-13','2019-01-03','600000','True')
INSERT INTO GiaoDich(MaDoan,ID_DaiDien,SoNguoi,SoPhong,NgayBatDau,NgayKetThuc,TongTien,IsActive) VALUES ('MD5',5,2,1,'2019-01-13','2019-01-03','700000','True')

-- Chèn dữ liệu bảng TaiKhoan
INSERT INTO TaiKhoan(TenDangNhap,MatKhau,ID_GiaoDich) VALUES ('khach1','123456',1)
INSERT INTO TaiKhoan(TenDangNhap,MatKhau,ID_GiaoDich) VALUES ('khach2','123456',2)
INSERT INTO TaiKhoan(TenDangNhap,MatKhau,ID_GiaoDich) VALUES ('khach3','123456',3)
INSERT INTO TaiKhoan(TenDangNhap,MatKhau,ID_GiaoDich) VALUES ('khach4','123456',4)
INSERT INTO TaiKhoan(TenDangNhap,MatKhau,ID_GiaoDich) VALUES ('khach5','123456',5)

--Chèn dữ liệu bảng ThietHai
INSERT INTO ThietHai(ID_Phong,TaiSanThietHai,ChiPhiDenBu,ID_GiaoDich) VALUES (1,'ThietHai1','0',1)
INSERT INTO ThietHai(ID_Phong,TaiSanThietHai,ChiPhiDenBu,ID_GiaoDich) VALUES (2,'ThietHai1','0',2)
INSERT INTO ThietHai(ID_Phong,TaiSanThietHai,ChiPhiDenBu,ID_GiaoDich) VALUES (3,'ThietHai1','0',3)
INSERT INTO ThietHai(ID_Phong,TaiSanThietHai,ChiPhiDenBu,ID_GiaoDich) VALUES (4,'ThietHai1','0',4)
INSERT INTO ThietHai(ID_Phong,TaiSanThietHai,ChiPhiDenBu,ID_GiaoDich) VALUES (5,'ThietHai1','0',5)

--Chèn dữ liệu bảng ChiTietGiaoDich
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (1,1,1,'2019-01-01','2019-01-03','100000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (1,2,1,'2019-01-01','2019-01-03','100000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (2,3,2,'2019-01-01','2019-01-03','200000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (2,4,2,'2019-01-01','2019-01-03','200000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (3,5,3,'2019-01-01','2019-01-03','250000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (3,6,3,'2019-01-01','2019-01-03','250000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (4,7,4,'2019-01-01','2019-01-03','300000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (4,8,4,'2019-01-01','2019-01-03','300000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (5,9,5,'2019-01-01','2019-01-03','350000')
INSERT INTO ChiTietGiaoDich(ID_GiaoDich,ID_KhachHang,ID_Phong,NgayBatDau,NgayKetThuc,ThanhTien) VALUES (5,10,5,'2019-01-01','2019-01-03','350000')

--Chèn dữ liệu bảng NhanVien
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien1','NhanVien1','123456')
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien2','NhanVien2','123456')
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien3','NhanVien3','123456')
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien4','NhanVien4','123456')
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien5','NhanVien5','123456')
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien6','NhanVien6','123456')
INSERT INTO NhanVien(TenNhanVien,TenDangNhap,MatKhau) VALUES ('NhanVien7','NhanVien7','123456')