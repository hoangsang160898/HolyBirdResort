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
    public class RoomDAO
    {
        static SqlConnection con;

        public static List<RoomDTO> LoadRoomEmptyAll()
        {
            string sTruyVan = @"Select * from Phong where TrangThai=N'Trống'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<RoomDTO> result = new List<RoomDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RoomDTO room = new RoomDTO();
                room.Id = dt.Rows[i]["ID"].ToString();
                room.SoTang = dt.Rows[i]["SoTang"].ToString();
                room.Gia = dt.Rows[i]["Gia"].ToString();
                room.TrangThai = dt.Rows[i]["TrangThai"].ToString();
                room.HinhThuc = dt.Rows[i]["HinhThuc"].ToString();
                room.HangPhong = dt.Rows[i]["HangPhong"].ToString();
                result.Add(room);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
        public static List<RoomDTO> LoadRoomEmpty(string hangphong, string tang, string hinhthuc)
        {
            con = DataProvider.OpenConnection();
            List<RoomDTO> result = new List<RoomDTO>();

            SqlCommand cmd = new SqlCommand("usp_TraCuuPhong", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@SoTang", SqlDbType.Int).Value = tang;
            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 20).Value = "Trống";
            cmd.Parameters.Add("@HinhThuc", SqlDbType.NVarChar, 20).Value = hinhthuc;
            cmd.Parameters.Add("@HangPhong", SqlDbType.NVarChar, 20).Value = hangphong;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RoomDTO room = new RoomDTO();
                room.Id = (reader["ID"]).ToString();
                room.SoTang = (reader["SoTang"]).ToString();
                room.Gia = (reader["Gia"]).ToString();
                room.TrangThai = (reader["TrangThai"]).ToString();
                room.HinhThuc = (reader["HinhThuc"]).ToString();
                room.HangPhong = (reader["HangPhong"]).ToString();
                result.Add(room);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
    }
}
