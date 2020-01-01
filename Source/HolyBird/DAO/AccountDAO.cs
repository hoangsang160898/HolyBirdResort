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
    }
}
