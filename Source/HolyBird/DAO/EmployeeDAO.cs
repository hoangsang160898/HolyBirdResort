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
                employee.Name = dt.Rows[i]["TenNhanVien"].ToString();
                employee.Username = dt.Rows[i]["TenDangNhap"].ToString();
                employee.Password = dt.Rows[i]["MatKhau"].ToString();
                result.Add(employee);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
    }
}