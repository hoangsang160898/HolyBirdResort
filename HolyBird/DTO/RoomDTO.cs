using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomDTO
    {
        string id;
        string sotang;
        string gia;
        string trangthai;
        string hinhthuc;
        string hangphong;
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string SoTang
        {
            get => sotang;
            set => sotang = value;
        }
        public string Gia
        {
            get => gia;
            set => gia = value;
        }
        public string TrangThai
        {
            get => trangthai;
            set => trangthai = value;
        }
        public string HinhThuc
        {
            get => hinhthuc;
            set => hinhthuc = value;
        }
        public string HangPhong
        {
            get => hangphong;
            set => hangphong = value;
        }
        public RoomDTO()
        {
            id = sotang = gia = trangthai = hinhthuc = hangphong;
        }
        public RoomDTO(string id, string sotang, string gia, string trangthai, string hinhthuc, string hangphong)
        {
            this.id = id;
            this.sotang = sotang;
            this.trangthai = trangthai;
            this.hinhthuc = hinhthuc;
            this.hangphong = hangphong;
        }
    }
}
