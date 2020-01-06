using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BillChildBUS
    {
        public static List<BillChildDTO> LoadBillChild(string magiaodich)
        {
            List<BillChildDTO> result = BillChildDAO.LoadBillChild(magiaodich);
            if (result != null)
            {
                return result;
            }
            return null;
        }
        public static void RemoveBillChild(string id_chitietgiaodich)
        {
            BillChildDAO.RemoveBillChild(id_chitietgiaodich);
        }
    }
}
