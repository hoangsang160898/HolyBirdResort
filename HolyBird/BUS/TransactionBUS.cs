using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class TransactionBUS
    {
        public static TransactionDTO GetTransaction(string id_giaodich)
        {
            TransactionDTO result = TransactionDAO.GetTransaction(id_giaodich);
            if (result == null)
                return null;
            return result;
        }
        public static TransactionDTO SearchTransaction(string madoan)
        {
            TransactionDTO result = TransactionDAO.SearchTransaction(madoan);
            if (result == null)
                return null;
            return result;
        }
        public static void UpdateSumMoney(string magiaodich)
        {
            TransactionDAO.UpdateSumMoney(magiaodich);
        }
        public static string GetNameLeader(string makhachhang)
        {
            return TransactionDAO.GetNameLeader(makhachhang);
        } }
}
