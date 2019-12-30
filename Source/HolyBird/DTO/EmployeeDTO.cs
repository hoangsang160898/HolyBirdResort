using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        string id;
        string tennhanvien;
        string tendangnhap;
        string matkhau;

        public string Id
        {
            get => id;
            set => id = value;
        }
        public string TenNhanVien
        {
            get => tennhanvien;
            set => tennhanvien = value;
        }
        public string TenDangNhap
        {
            get => tendangnhap;
            set => tendangnhap = value;
        }
        public string MatKhau
        {
            get => matkhau;
            set => matkhau = value;
        }
        public EmployeeDTO()
        {
            id = tennhanvien = tendangnhap = matkhau = "";
        }
    }
}
