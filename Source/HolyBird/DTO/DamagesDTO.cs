using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DamagesDTO
    {
        string id;
        string id_phong;
        string taisanthiethai;
        string chiphidenbu;
        string id_giaodich;
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Id_Phong
        {
            get => id_phong;
            set => id_phong = value;
        }
        public string TaiSanThietHai
        {
            get => taisanthiethai;
            set => taisanthiethai = value;
        }
        public string ChiPhiDenBu
        {
            get => chiphidenbu;
            set => chiphidenbu = value;
        }
        public string Id_GiaoDich
        {
            get => id_giaodich;
            set => id_giaodich = value;
        }
        public DamagesDTO()
        {
            id = id_phong = taisanthiethai = chiphidenbu = id_giaodich = "";
        }
    }
}
