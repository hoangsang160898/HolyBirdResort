using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailRoomReservedDTO
    {
        string madoan;
        string id_khachhang;
        string id_giaodich;
        string id_chitietgiaodich;
        string hoten;
        string cmnd;
        string maphong;
        string ngaybatdau;
        string ngayketthuc;
        string dongia;
        string thanhtien;
        public string MaDoan
        {
            get => madoan;
            set => madoan = value;
        }
        public string Id_KhachHang
        {
            get => id_khachhang;
            set => id_khachhang = value;
        }
        public string Id_GiaoDich
        {
            get => id_giaodich;
            set => id_giaodich = value;
        }
        public string Id_ChiTietGiaoDich
        {
            get => id_chitietgiaodich;
            set => id_chitietgiaodich = value;
        }
        public string HoTen
        {
            get => hoten;
            set => hoten = value;
        }
        public string CMND
        {
            get => cmnd;
            set => cmnd = value;
        }
        public string MaPhong
        {
            get => maphong;
            set => maphong = value;
        }
        public string NgayBatDau
        {
            get => ngaybatdau;
            set => ngaybatdau = value;
        }
        public string NgayKetThuc
        {
            get => ngayketthuc;
            set => ngayketthuc = value;
        }
        public string DonGia
        {
            get => dongia;
            set => dongia = value;
        }
        public string ThanhTien
        {
            get => thanhtien;
            set => thanhtien = value;
        }
        public DetailRoomReservedDTO()
        {
            madoan = maphong = hoten = cmnd = ngaybatdau = ngayketthuc = dongia = thanhtien = id_khachhang = id_giaodich = id_chitietgiaodich = "";
        }
    }
}
