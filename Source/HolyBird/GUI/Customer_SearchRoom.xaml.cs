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
    /// Interaction logic for Customer_SearchRoom.xaml
    /// </summary>
    public partial class Customer_SearchRoom : Page
    {
        List<RoomDTO> tempRooms = new List<RoomDTO>();
        List<RoomDTO> tempRoomsChoosen = new List<RoomDTO>();
        public Customer_SearchRoom()
        {
            tempRooms.Add(new RoomDTO { Id = "12312", SoTang = "1", TrangThai = "0", HinhThuc = "2 giường đơn", HangPhong = "Thường", Gia="750000" });
            tempRooms.Add(new RoomDTO { Id = "12321312", SoTang = "2", TrangThai = "1", HinhThuc = "1 giường đôi", HangPhong = "Thường", Gia = "750000" });
            tempRooms.Add(new RoomDTO { Id = "123ew12", SoTang = "2", TrangThai = "0", HinhThuc = "2 giường đôi", HangPhong = "Trung", Gia = "900000" });
            tempRooms.Add(new RoomDTO { Id = "12321f12", SoTang = "3", TrangThai = "0", HinhThuc = "1 giường đơn", HangPhong = "Cao", Gia = "1500000" });
            tempRooms.Add(new RoomDTO { Id = "123ew1322", SoTang = "1", TrangThai = "1", HinhThuc = "2 giường đôi", HangPhong = "Trung", Gia = "850000" });
            tempRooms.Add(new RoomDTO { Id = "12321f1112", SoTang = "3", TrangThai = "1", HinhThuc = "2 giường đơn", HangPhong = "Cao", Gia = "1800000" });
            InitializeComponent();
        }

        private void searchRoom(object sender, RoutedEventArgs e)
        {

        }

        private void addRoom(object sender, RoutedEventArgs e)
        {
            if (listSearchRoom.SelectedItems.Count > 0)
            {
                RoomDTO tmp = (RoomDTO)listSearchRoom.SelectedItems[0];
                tempRoomsChoosen.Add(tmp);
                tempRooms.Remove(tmp);
                listSearchRoom.Items.Refresh();
                listRoomChoosen.Items.Refresh();
            }
            addRoom_name.IsEnabled = false;
        }

        private void removeRoom(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_Rooms(object sender, RoutedEventArgs e)
        {
            listSearchRoom.ItemsSource = tempRooms;
            listRoomChoosen.ItemsSource = tempRoomsChoosen;
        }

        private void selectItemRemoveRoom(object sender, MouseButtonEventArgs e)
        {
            if (listRoomChoosen.SelectedItems.Count > 0)
            {
                removeRoom_name.IsEnabled = true;
            }
            else
            {
                removeRoom_name.IsEnabled = false;
            }
        }

        private void selectItemAddRoom(object sender, MouseButtonEventArgs e)
        {
            if (listSearchRoom.SelectedItems.Count > 0)
            {
                addRoom_name.IsEnabled = true;
            }
            else
            {
                addRoom_name.IsEnabled = false;
            }
        }
    }
}
