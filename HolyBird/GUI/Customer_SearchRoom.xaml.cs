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
        public Customer_SearchRoom()
        {
            InitializeComponent();
        }

        private void searchRoom(object sender, RoutedEventArgs e)
        {
            string hangphong = HangPhong_name.Text;
            string tang = Tang_name.Text;
            string hinhthuc = HinhThuc_name.Text;
            if (hangphong != "" && tang != "" && hinhthuc != "")
            {
                Global.roomsEmpty = RoomBUS.LoadRoomEmpty(hangphong, tang, hinhthuc);

                foreach (RoomDTO item in Global.roomsChoosen)
                {
                    if (Global.roomsEmpty.Count > 0)
                    {
                        var itemToRemove = Global.roomsEmpty.Find(r => r.Id == item.Id);
                        if (itemToRemove != null)
                        {
                            Global.roomsEmpty.Remove(itemToRemove);
                        }
                    }
                }

                listSearchRoom.ItemsSource = Global.roomsEmpty;
                if (Global.roomsEmpty.Count == 0)
                {
                    noRoomEmpty.Visibility = Visibility.Visible;
                }
                else
                {
                    noRoomEmpty.Visibility = Visibility.Collapsed;
                }
            }
            addRoom_name.IsEnabled = false;
        }

        private void addRoom(object sender, RoutedEventArgs e)
        {
            if (listSearchRoom.SelectedItems.Count > 0)
            {
                RoomDTO tmp = (RoomDTO)listSearchRoom.SelectedItems[0];
                Global.roomsChoosen.Add(tmp);
                Global.roomsEmpty.Remove(tmp);
                listSearchRoom.Items.Refresh();
                listRoomChoosen.Items.Refresh();
                noRoomChoosen.Visibility = Visibility.Collapsed;
                if (listSearchRoom.Items.Count == 0)
                {
                    noRoomEmpty.Visibility = Visibility.Visible;
                }
            }
            addRoom_name.IsEnabled = false;
        }

        private void removeRoom(object sender, RoutedEventArgs e)
        {
            if (listRoomChoosen.SelectedItems.Count > 0)
            {
                RoomDTO tmp = (RoomDTO)listRoomChoosen.SelectedItems[0];
                Global.roomsEmpty.Add(tmp);
                Global.roomsChoosen.Remove(tmp);
                listSearchRoom.Items.Refresh();
                listRoomChoosen.Items.Refresh();
                if (listRoomChoosen.Items.Count == 0)
                {
                    noRoomChoosen.Visibility = Visibility.Visible;
                }
                //if (listSearchRoom.Items.Count != 0)
                {
                    noRoomEmpty.Visibility = Visibility.Collapsed;
                }
            }
            removeRoom_name.IsEnabled = false;
        }

        private void Window_Loaded_Rooms(object sender, RoutedEventArgs e)
        {
            listSearchRoom.ItemsSource = Global.roomsEmpty;
            listRoomChoosen.ItemsSource = Global.roomsChoosen;
            if (Global.roomsEmpty== null)
            {
                noRoomEmpty.Visibility = Visibility.Visible;
            }
            else
            {
                noRoomEmpty.Visibility = Visibility.Collapsed;
            }
            if (Global.roomsChoosen.Count == 0)
            {
                noRoomChoosen.Visibility = Visibility.Visible;
            }
            else
            {
                noRoomChoosen.Visibility = Visibility.Collapsed;
            }
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
