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
    public class ActivityDAO
    {
        static SqlConnection con;
        public static List<ActivityDTO> LoadActivities()
        {
            string sTruyVan = @"select distinct (CTGD.ID_GiaoDich),GD.MaDoan,P.TrangThai
                                from ChiTietGiaoDich CTGD join Phong P on CTGD.ID_Phong=P.ID join GiaoDich GD on GD.ID=CTGD.ID_GiaoDich";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ActivityDTO> result = new List<ActivityDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ActivityDTO activity = new ActivityDTO();
                activity.Id = dt.Rows[i]["ID_GiaoDich"].ToString();
                activity.MaDoan = dt.Rows[i]["MaDoan"].ToString();
                activity.TrangThai = dt.Rows[i]["TrangThai"].ToString();
              
                result.Add(activity);
            }
            DataProvider.CloseConnection(con);
            return result;
        }

        public static void AcceptRoom(string madoan)
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("usp_NhanPhong", con);
            cmd.CommandType = CommandType.StoredProcedure;

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
        public static void CancelRoom(string magiaodich)
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("usp_HuyGiaoDich", con);
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
    }
}
