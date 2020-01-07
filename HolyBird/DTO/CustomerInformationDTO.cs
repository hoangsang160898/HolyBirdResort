using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerInformationDTO
    {
        string cmnd;
        string hoten;

        public string CMND
        {
            get => cmnd;
            set => cmnd = value;
        }
        public string HoTen
        {
            get => hoten;
            set => hoten = value;
        }
        public CustomerInformationDTO()
        {
           hoten = cmnd = "";
        }
        public CustomerInformationDTO(string hoten, string cmnd)
        {
            this.hoten = hoten;
            this.cmnd = cmnd;
        }
    }
}
