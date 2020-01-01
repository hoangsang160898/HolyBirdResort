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
    }
}
