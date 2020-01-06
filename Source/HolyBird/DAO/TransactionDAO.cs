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

        public static TransactionDTO SearchTransaction(string madoan)
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("usp_TraCuuGiaoDich", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaDoan", madoan);
            cmd.Parameters.AddWithValue("@IsActive", true);
            cmd.Parameters.AddWithValue("@minDate", "2020-1-8");
            cmd.Parameters.AddWithValue("@maxDate", "2020-1-8");
            TransactionDTO result = new TransactionDTO();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TransactionDTO transaction = new TransactionDTO();
                transaction.Id = (reader["ID"]).ToString();
                transaction.MaDoan = (reader["MaDoan"]).ToString();
                transaction.Id_DaiDien = (reader["ID_DaiDien"]).ToString();
                transaction.SoNguoi = (reader["SoNguoi"]).ToString();
                transaction.SoPhong = (reader["SoPhong"]).ToString();
                transaction.NgayBatDau = (reader["NgayBatDau"]).ToString();
                transaction.NgayKetThuc = (reader["NgayKetThuc"]).ToString();
                transaction.TongTien = (reader["TONGTIEN"]).ToString();
                transaction.IsActive = (reader["IsActive"]).ToString();
                result = transaction;
            }
            DataProvider.CloseConnection(con);
            return result;

        }
        public static void UpdateSumMoney(string magiaodich)
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("Sp_TongTien", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaGiaoDich", magiaodich);

            try
            {
                cmd.ExecuteNonQuery();
                DataProvider.CloseConnection(con);
            }
            catch (Exception e)
            {
                DataProvider.CloseConnection(con);
            }
            DataProvider.CloseConnection(con);
        }
        public static string GetNameLeader(string makhachhang)
        {
            string sTruyVan = @"Select * from KhachHang where ID = N'" + makhachhang + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string result = "0";
            result = dt.Rows[0]["HoTen"].ToString();
            DataProvider.CloseConnection(con);

            return result;
        }
    }
}
