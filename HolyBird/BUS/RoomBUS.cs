using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class RoomBUS
    {
        public static List<RoomDTO> LoadRoomEmptyAll()
        {
            List<RoomDTO> result = RoomDAO.LoadRoomEmptyAll();
            if (result != null)
            {
                return result;
            }
            return null;
        }
        public static List<RoomDTO> LoadRoomEmpty(string hangphong, string tang, string hinhthuc)
        {
            List<RoomDTO> result = RoomDAO.LoadRoomEmpty(hangphong, tang, hinhthuc);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
