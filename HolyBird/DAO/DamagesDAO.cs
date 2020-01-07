using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DamagesDAO
    {
        static SqlConnection con;
        public static List<DamagesDTO> LoadDamages(string magiaodich)
        {
            string sTruyVan = @"select * from ThietHai
                                where ID_GiaoDich=N'" + magiaodich + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DamagesDTO> result = new List<DamagesDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DamagesDTO damages = new DamagesDTO();
                damages.Id = dt.Rows[i]["ID"].ToString();
                damages.Id_Phong = dt.Rows[i]["ID_Phong"].ToString();
                damages.Id_GiaoDich = dt.Rows[i]["ID_GiaoDich"].ToString();
                damages.TaiSanThietHai = dt.Rows[i]["TaiSanThietHai"].ToString();
                damages.ChiPhiDenBu = dt.Rows[i]["ChiPhiDenBu"].ToString();
                result.Add(damages);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
    }
}
