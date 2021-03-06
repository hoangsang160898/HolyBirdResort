﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class EmployeeDAO
    {
        static SqlConnection con;

        public static List<EmployeeDTO> LoadEmployees()
        {
            string sTruyVan = @"Select * from NhanVien";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<EmployeeDTO> result = new List<EmployeeDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EmployeeDTO employee = new EmployeeDTO();
                employee.Id = dt.Rows[i]["ID"].ToString();
                employee.TenNhanVien = dt.Rows[i]["TenNhanVien"].ToString();
                employee.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                employee.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                result.Add(employee);
            }
            DataProvider.CloseConnection(con);
            return result;
        }

        public static EmployeeDTO LogIn(string username, string password)
        {
            string sTruyVan = @"select * from NhanVien where TenDangNhap= '" + username + @"' and MatKhau = '" + password + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            EmployeeDTO employee = new EmployeeDTO();

            employee.Id = dt.Rows[0]["ID"].ToString();
            employee.TenNhanVien = dt.Rows[0]["TenNhanVien"].ToString();

            DataProvider.CloseConnection(con);
            return employee;
        }

        public static void InsertTransaction(string madoan, List<CustomerInformationDTO> customers, string ngaybatdau, string ngayketthuc)
        {
            DataTable danhsachkhachhang = new DataTable();
            danhsachkhachhang.Columns.Add("Name", typeof(string));
            danhsachkhachhang.Columns.Add("IdCard", typeof(string));

            for (int i = 0; i < customers.Count; i++)
            {
                DataRow row = danhsachkhachhang.NewRow();
                row["Name"] = customers[i].HoTen;
                row["IdCard"] = customers[i].CMND;
                danhsachkhachhang.Rows.Add(row);
            }

            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("usp_DangKyGiaoDich", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaDoan", madoan);
            cmd.Parameters.AddWithValue("@DanhSachKhachHang", danhsachkhachhang);
            cmd.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);

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
        public static List<string> LoadIdRoomOrdered(string id_giaodich)
        {
            string sTruyVan = @"Select Distinct (ID_Phong) from ChiTietGiaoDich
                                where ID_GiaoDich=N'" + id_giaodich + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<string> result = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["ID_Phong"].ToString();
                result.Add(id);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
        public static void UpdateDamages(string maphongthiethai, string magiaodichthiethai, string tenthiethai, string chiphithiethai )
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("Sp_CapNhatThietHai", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhongThietHai", maphongthiethai);
            cmd.Parameters.AddWithValue("@MaGiaoDichThietHai", magiaodichthiethai);
            cmd.Parameters.AddWithValue("@TenThietHai", tenthiethai);
            cmd.Parameters.AddWithValue("@ChiPhiThietHai", chiphithiethai);

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
