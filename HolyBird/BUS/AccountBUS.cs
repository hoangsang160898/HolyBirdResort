using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class AccountBUS
    {
        public static AccountDTO LogIn(string username, string password)
        {
            Global.account = AccountDAO.LogIn(username, password);
            if (Global.account == null)
                return null;
            return Global.account;
        }
        public static void RemoveDetailTransaction(string id_giaodich, string id_chitietgiaodich)
        {
            AccountDAO.RemoveDetailTransaction(id_giaodich, id_chitietgiaodich);
        }
        public static void InsertRoomOrdered(List<DetailReservedDTO> roomsOrdered, string madoan)
        {
            AccountDAO.InsertRoomOrdered(roomsOrdered, madoan);
        }
    }
}
