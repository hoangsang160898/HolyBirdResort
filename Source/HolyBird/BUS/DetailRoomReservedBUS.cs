using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DetailRoomReservedBUS
    {
        public static List<DetailRoomReservedDTO> LoadDetailRoomReserved(string id_giaodich)
        {
            List<DetailRoomReservedDTO> result= DetailRoomReservedDAO.LoadDetailRoomReserved(id_giaodich);
            if (result == null)
                return null;
            return result;
        }
    }
}
