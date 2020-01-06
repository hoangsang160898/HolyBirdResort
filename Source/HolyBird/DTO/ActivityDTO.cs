using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActivityDTO
    {
        string id;
        string madoan;
        string trangthai;
        string sophong;
        string isactive;
        public string SoPhong
        {
            get => sophong;
            set => sophong = value;
        }
        public string IsActive
        {
            get => isactive;
            set => isactive = value;
        }
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
        public ActivityDTO()
        {
            id = madoan = trangthai = "";
        }
        public ActivityDTO(string id, string madoan, string trangthai)
        {
            this.id = id;
            this.madoan = madoan;
            this.trangthai = trangthai;
        }
    }
}
