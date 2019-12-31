using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TransactionDTO
    {
        string id;
        string madoan;
        string id_daidien;
        string songuoi;
        string sophong;
        string ngaybatdau;
        string ngayketthuc;
        string tongtien;
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string MaDoan
        {
            get => madoan;
            set => madoan = value;
        }
        public string Id_DaiDien
        {
            get => id_daidien;
            set => id_daidien = value;
        }
        public string SoNguoi
        {
            get => songuoi;
            set => songuoi = value;
        }
        public string SoPhong
        {
            get => sophong;
            set => sophong = value;
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
        public string TongTien
        {
            get => tongtien;
            set => tongtien = value;
        }
        public TransactionDTO()
        {
            id = madoan = songuoi=id_daidien=sophong=ngaybatdau=ngayketthuc=tongtien = "";
        }
        public TransactionDTO(string id, string madoan, string id_daidien, string songuoi, string sophong, string ngayketthuc, string ngaybatdau, string tongtien)
        {
            this.id = id;
            this.madoan = madoan;
            this.id_daidien= id_daidien;
            this.songuoi = songuoi;
            this.sophong = sophong;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.tongtien = tongtien;
        }
    }
}
