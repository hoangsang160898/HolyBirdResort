using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailReservedDTO
    {
        string makhachhang;
        string maphong;
        string hoten;
        string ngaybatdau;
        string ngayketthuc;
        public string MaKhachHang
        {
            get => makhachhang;
            set => makhachhang = value;
        }
        public string HoTen
        {
            get => hoten;
            set => hoten = value;
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
        public DetailReservedDTO()
        {
            makhachhang = maphong = ngaybatdau = ngayketthuc = hoten = "";
        }
    }
}
