using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CustomerBUS
    {
        public static List<CustomerDTO> LoadCustomer(string id_giaodich)
        {
            List<CustomerDTO> result = CustomerDAO.LoadCustomer(id_giaodich);
            if (result == null)
                return null;
            return result;
        }
    }
}
