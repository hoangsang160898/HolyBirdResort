using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailTransactionDTO
    {
        string id;
        string id_giaodich;
        string id_khachhang;
        string id_phong;
        string ngaybatdau;
        string ngayketthuc;
        string thanhtien;
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Id_GiaoDich
        {
            get => id_giaodich;
            set => id_giaodich = value;
        }
        public string Id_KhachHang
        {
            get => id_khachhang;
            set => id_khachhang = value;
        }
        public string Id_Phong
        {
            get => id_phong;
            set => id_phong = value;
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
        public string ThanhTien
        {
            get => thanhtien;
            set => thanhtien = value;
        }
        public DetailTransactionDTO()
        {
            id = id_giaodich = id_khachhang = id_phong = ngaybatdau = ngayketthuc = thanhtien = "";
        }
    }
}
