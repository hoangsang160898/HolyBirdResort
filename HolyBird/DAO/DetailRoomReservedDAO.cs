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
    public class DetailRoomReservedDAO
    {
        static SqlConnection con;
        public static List<DetailRoomReservedDTO> LoadDetailRoomReserved(string id_giaodich)
        {
            string sTruyVan = @"Select GD.MaDoan, KH.HoTen, KH.ID, KH.CMND, CTGD.ID_Phong, CTGD.ID as ID_ChiTietGiaoDich, CTGD.ID_GiaoDich, format(CTGD.NgayBatDau,'MM/dd/yyyy') as NgayBatDau, format(CTGD.NgayKetThuc,'MM/dd/yyyy') as NgayKetThuc, P.Gia, CTGD.ThanhTien
                                from ChiTietGiaoDich CTGD join KhachHang KH on CTGD.ID_KhachHang=KH.ID, GiaoDich GD, Phong P
                                where GD.ID=CTGD.ID_GiaoDich and CTGD.ID_Phong=P.ID and CTGD.ID_GiaoDich=N'"+id_giaodich+"'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DetailRoomReservedDTO> result = new List<DetailRoomReservedDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DetailRoomReservedDTO detail = new DetailRoomReservedDTO();
                detail.MaDoan = dt.Rows[i]["MaDoan"].ToString();
                detail.Id_GiaoDich = dt.Rows[i]["ID_GiaoDich"].ToString();
                detail.Id_ChiTietGiaoDich = dt.Rows[i]["ID_ChiTietGiaoDich"].ToString();
                detail.Id_KhachHang = dt.Rows[i]["ID"].ToString();
                detail.HoTen = dt.Rows[i]["HoTen"].ToString();
                detail.CMND = dt.Rows[i]["CMND"].ToString();
                detail.MaPhong = dt.Rows[i]["ID_Phong"].ToString();
                detail.NgayBatDau = dt.Rows[i]["NgayBatDau"].ToString();
                detail.NgayKetThuc = dt.Rows[i]["NgayKetThuc"].ToString();
                detail.DonGia = dt.Rows[i]["Gia"].ToString();
                detail.ThanhTien = dt.Rows[i]["ThanhTien"].ToString();
                result.Add(detail);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
    }
}
