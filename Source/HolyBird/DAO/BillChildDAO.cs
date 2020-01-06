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
    public class BillChildDAO
    {
        static SqlConnection con;
        public static List<BillChildDTO> LoadBillChild(string magiaodich)
        {
            string sTruyVan = @"select  CTGD.ID_GiaoDich, CTGD.ID as ID_ChiTietGiaoDich, CTGD.ID_Phong as ID_Phong, P.Gia as DonGia,datediff(day,CTGD.NgayBatDau,CTGD.NgayKetThuc)+1 as ThoiGian, (cast(CTGD.ThanhTien as int) + isnull(cast(TH.ChiPhiDenBu as int),0))as ThanhTien
                                from ChiTietGiaoDich CTGD join Phong P on P.ID=CTGD.ID_Phong left join ThietHai TH on TH.ID_Phong=CTGD.ID_Phong and TH.ID_GiaoDich=CTGD.ID_GiaoDich
                                where CTGD.ID_GiaoDich=N'"+magiaodich+"'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BillChildDTO> result = new List<BillChildDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BillChildDTO billChild = new BillChildDTO();
                billChild.Id_ChiTietGiaoDich = dt.Rows[i]["ID_ChiTietGiaoDich"].ToString();
                billChild.Id_Phong = dt.Rows[i]["ID_Phong"].ToString();
                billChild.DonGia = dt.Rows[i]["DonGia"].ToString();
                billChild.ThoiGian = dt.Rows[i]["ThoiGian"].ToString();
                billChild.ThanhTien = dt.Rows[i]["ThanhTien"].ToString();
                result.Add(billChild);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
        public static void RemoveBillChild(string id_chitietgiaodich)
        {
            con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("Sp_TraPhong", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaChiTietGiaoDich", id_chitietgiaodich);

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
