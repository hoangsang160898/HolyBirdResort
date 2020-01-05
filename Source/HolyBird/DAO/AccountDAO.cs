using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{

    public class AccountDAO
    {
        static SqlConnection con;

        public static AccountDTO LogIn(string username, string password)
        {
            string sTruyVan = @"select * from TaiKhoan where TenDangNhap= '" + username + @"' and MatKhau = '" + password + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            AccountDTO account = new AccountDTO();

            account.Id = dt.Rows[0]["ID"].ToString();
            account.Id_GiaoDich = dt.Rows[0]["ID_GiaoDich"].ToString();

            DataProvider.CloseConnection(con);
            return account;
        }
        public static void RemoveDetailTransaction(string id_giaodich, string id_chitietgiaodich)
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("usp_HuyChiTietGiaoDich", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaChiTietGiaoDich", id_chitietgiaodich);
            cmd.Parameters.AddWithValue("@MaGiaoDich", id_giaodich);

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
        public static void InsertRoomOrdered(List<DetailReservedDTO> roomsOrdered, string madoan)
        {
            DataTable danhsachdatcho = new DataTable();
            danhsachdatcho.Columns.Add("MaKhachHang", typeof(string));
            danhsachdatcho.Columns.Add("MaPhong", typeof(string));
            danhsachdatcho.Columns.Add("NgayBatDau", typeof(string));
            danhsachdatcho.Columns.Add("NgayKetThuc", typeof(string));

            for (int i = 0; i < roomsOrdered.Count; i++)
            {
                DataRow row = danhsachdatcho.NewRow();
                row["MaKhachHang"] = roomsOrdered[i].MaKhachHang;
                row["MaPhong"] = roomsOrdered[i].MaPhong;
                row["NgayBatDau"] = roomsOrdered[i].NgayBatDau;
                row["NgayKetThuc"] = roomsOrdered[i].NgayKetThuc;
                danhsachdatcho.Rows.Add(row);
                Console.WriteLine(row["MaKhachHang"]);
                Console.WriteLine(row["MaPhong"]);
                Console.WriteLine(row["NgayBatDau"]);
                Console.WriteLine(row["NgayKetThuc"]);
            }

            //DataRow row = danhsachdatcho.NewRow();
            //row["MaKhachHang"] = "12";
            //row["MaPhong"] = "1";
            //row["NgayBatDau"] ="1/6/2020";
            //row["NgayKetThuc"] = "1/7/2020";
            //danhsachdatcho.Rows.Add(row);

            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("usp_DatCho", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DanhSachDatCho", danhsachdatcho);
            cmd.Parameters.AddWithValue("@MaDoan", madoan);

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
    }
}
