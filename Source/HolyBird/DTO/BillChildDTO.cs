using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillChildDTO
    {
        string id_phong;
        string dongia;
        string thoigian;
        string thanhtien;
        public string Id_Phong
        {
            get => id_phong;
            set => id_phong = value;
        }
        public string DonGia
        {
            get => dongia;
            set => dongia = value;
        }
        public string ThoiGian
        {
            get => thoigian;
            set => thoigian = value;
        }
        public string ThanhTien
        {
            get => thanhtien;
            set => thanhtien = value;
        }
        public BillChildDTO()
        {
            id_phong = dongia = thoigian = thanhtien = "";
        }
    }
}

