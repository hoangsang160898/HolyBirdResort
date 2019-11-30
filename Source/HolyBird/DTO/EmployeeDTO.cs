using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        string id;
        string name;
        string username;
        string password;

        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Username
        {
            get => username;
            set => username = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        public EmployeeDTO()
        {
            id = name = username = password;
        }
    }
}
