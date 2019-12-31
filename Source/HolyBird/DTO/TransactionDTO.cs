using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TransactionDTO
    {
        string id;
        string madoan;
        string trangthai;
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string MaDoan
        {
            get => madoan;
            set => madoan = value;
        }
        public string TrangThai
        {
            get => trangthai;
            set => trangthai = value;
        }
        public TransactionDTO()
        {
            id = madoan = trangthai = "";
        }
        public TransactionDTO(string id, string madoan, string trangthai)
        {
            this.id = id;
            this.madoan = madoan;
            this.trangthai = trangthai;
        }
    }
}
