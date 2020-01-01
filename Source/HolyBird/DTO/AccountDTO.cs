using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        string id;
        string id_giaodich;
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Id_GiaoDich
        {
            get => id_giaodich;
            set => id_giaodich = value;
        }
        public AccountDTO()
        {
            id = id_giaodich = "";
        }
    }
}
