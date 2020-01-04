using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Global
    {
        public static EmployeeDTO employee;
        public static AccountDTO account;

        public static List<EmployeeDTO> employees;
        public static List<RoomDTO> rooms;
        public static List<RoomDTO> roomsEmpty;
        public static List<RoomDTO> roomsChoosen = new List<RoomDTO>();
    }
}
