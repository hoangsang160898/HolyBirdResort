using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;
using BUS;
namespace GUI
{
    /// <summary>
    /// Interaction logic for Customer_OrderRoom.xaml
    /// </summary>
    public partial class Customer_OrderRoom : Page
    {
        List<RoomDTO> tempRoomOrdered = new List<RoomDTO>();
        List<MemberDTO> tempMembers = new List<MemberDTO>();
        List<DetailRoomReservedDTO> tempRoomReserved = new List<DetailRoomReservedDTO>();
        public Customer_OrderRoom()
        {
            tempRoomOrdered.Add(new RoomDTO { HangPhong = "Thường", Id = "123", SoTang = "2", HinhThuc = "1 giường đôi" });
            tempRoomOrdered.Add(new RoomDTO { HangPhong = "Trung", Id = "1123", SoTang = "1", HinhThuc = "2 giường đôi" });
            tempRoomOrdered.Add(new RoomDTO { HangPhong = "Cao cấp", Id = "12223", SoTang = "3", HinhThuc = "2 giường đơn" });
            tempRoomOrdered.Add(new RoomDTO { HangPhong = "Cao cấp", Id = "12223", SoTang = "3", HinhThuc = "2 giường đơn" });
            tempMembers.Add(new MemberDTO { HoTen = "Truong Quang", Id = "sds2" });
            tempMembers.Add(new MemberDTO { HoTen = "Huynh Lam Phu Si", Id = "sd22s2" });
            tempMembers.Add(new MemberDTO { HoTen = "Le Hoang Sang", Id = "sds2" });
            tempMembers.Add(new MemberDTO { HoTen = "Nguyen Thi Thu Quyen", Id = "sds2" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { HoTen = "Truong Quang", MaPhong = "31231" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { HoTen = "Truong Quang", MaPhong = "31231" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { HoTen = "Truong Quang", MaPhong = "31231" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { HoTen = "Truong Quang", MaPhong = "31231" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { HoTen = "Trrqewrang", MaPhong = "31231" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { HoTen = "Truoneqwrqewg Quang", MaPhong = "31231" });
            InitializeComponent();
        }

        private void reserveRoom(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_RoomOrdered(object sender, RoutedEventArgs e)
        {
            listMember.ItemsSource = tempMembers;
            listMember.SelectedIndex = 0;
            listRoomOrdered.ItemsSource = tempRoomOrdered;
            listRoomReserved.ItemsSource = tempRoomReserved;
        }

        private void addPersonToRoom(object sender, RoutedEventArgs e)
        {

        }

        private void removePerSonInRoom(object sender, RoutedEventArgs e)
        {

        }

        private void listRoomReserved_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void selectItemRoomReserved(object sender, MouseButtonEventArgs e)
        {

        }

        private void selectItemRoom(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
