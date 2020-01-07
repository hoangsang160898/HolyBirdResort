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
    public class CustomerDAO
    {
        static SqlConnection con;
        public static List<CustomerDTO> LoadCustomer(string id_giaodich)
        {
            string sTruyVan = @"Select KH.ID, KH.Hoten, KH.CMND 
                                from KhachHang KH join ChiTietGiaoDich CTGD on CTGD.ID_KhachHang=KH.ID and CTGD.ID_GiaoDich=N'" + id_giaodich + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<CustomerDTO> result = new List<CustomerDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CustomerDTO customer = new CustomerDTO();
                customer.Id = dt.Rows[i]["ID"].ToString();
                customer.HoTen = dt.Rows[i]["HoTen"].ToString();
                customer.CMND = dt.Rows[i]["CMND"].ToString();
                result.Add(customer);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
    }
}
