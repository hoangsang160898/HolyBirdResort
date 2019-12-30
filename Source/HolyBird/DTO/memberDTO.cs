using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberDTO
    {
        string id;
        string cmnd;
        string hoten;
        public string Id
        {
            get => id;
            set => id = value;
        }
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
        public MemberDTO()
        {
            id = hoten = cmnd = "";
        }
        public MemberDTO(string id, string hoten, string cmnd)
        {
            this.id = id;
            this.hoten = hoten;
            this.cmnd = cmnd;
        }
    }
}
