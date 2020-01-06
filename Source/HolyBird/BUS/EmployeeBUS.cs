using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class EmployeeBUS
    {
        public static List<EmployeeDTO> LoadEmployees()
        {
            List<EmployeeDTO> result = EmployeeDAO.LoadEmployees();
            if (result == null)
            {
                return null;
            }
            return result;
        }
        public static EmployeeDTO LogIn(string username, string password)
        {
            Global.employee = EmployeeDAO.LogIn(username, password);
            if (Global.employee == null)
                return null;
            return Global.employee;
        }
        public static void InsertTransaction(string madoan, List<CustomerInformationDTO> customers, string ngaybatdau, string ngayketthuc)
        {
            EmployeeDAO.InsertTransaction(madoan, customers, ngaybatdau, ngayketthuc);
        }
        public static List<string> LoadIdRoomOrdered(string id_giaodich)
        {
            List<string> result = EmployeeDAO.LoadIdRoomOrdered(id_giaodich);
            if (result == null)
            {
                return null;
            }
            return result;
        }
        public static void UpdateDamages(string maphongthiethai, string magiaodichthiethai, string tenthiethai, string chiphithiethai)
        {
            EmployeeDAO.UpdateDamages(maphongthiethai, magiaodichthiethai, tenthiethai, chiphithiethai);
        }
    }
}
