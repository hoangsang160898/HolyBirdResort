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
        public static TransactionDTO transaction;
        public static List<EmployeeDTO> employees;
        public static List<RoomDTO> rooms;
        public static List<RoomDTO> roomsEmpty = new List<RoomDTO>();
        public static List<RoomDTO> roomsChoosen = new List<RoomDTO>();
        public static List<DetailRoomReservedDTO> roomsOrdered = new List<DetailRoomReservedDTO>();
        public static List<CustomerDTO> customersWillOrder;
        public static List<CustomerDTO> customers;
        public static List<DetailReservedDTO> roomsReserved = new List<DetailReservedDTO>();
    }
}
