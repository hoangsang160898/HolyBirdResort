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
    public class TransactionDAO
    {
        static SqlConnection con;
        public static TransactionDTO GetTransaction(string id_giaodich)
        {
          
            string sTruyVan = @"Select * from GiaoDich where ID = N'" + id_giaodich + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TransactionDTO result = new TransactionDTO();

            result.Id = dt.Rows[0]["ID"].ToString();
            result.MaDoan = dt.Rows[0]["MaDoan"].ToString();
            result.Id_DaiDien = dt.Rows[0]["ID_DaiDien"].ToString();
            result.SoNguoi = dt.Rows[0]["SoNguoi"].ToString();
            result.SoPhong = dt.Rows[0]["SoPhong"].ToString();
            result.NgayBatDau = dt.Rows[0]["NgayBatDau"].ToString();
            result.NgayKetThuc = dt.Rows[0]["NgayKetThuc"].ToString();
            result.TongTien = dt.Rows[0]["TONGTIEN"].ToString();

            DataProvider.CloseConnection(con);

            return result;
        }
    }
}
