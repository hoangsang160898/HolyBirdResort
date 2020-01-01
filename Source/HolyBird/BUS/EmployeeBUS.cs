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
    }
}
