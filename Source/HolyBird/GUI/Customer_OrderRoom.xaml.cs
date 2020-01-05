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
using System.Windows.Threading;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Customer_OrderRoom.xaml
    /// </summary>
    public partial class Customer_OrderRoom : Page
    {
        private DispatcherTimer dispatcherTimer;
        public Customer_OrderRoom()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            InitializeComponent();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            alert_error.Visibility = Visibility.Collapsed;
            alert_success.Visibility = Visibility.Collapsed;

            dispatcherTimer.IsEnabled = false;
        }
        private void reserveRoom(object sender, RoutedEventArgs e)
        {
            if (listRoomOrdered.Items.Count == Global.customers.Count)
            {
                AccountBUS.InsertRoomOrdered(Global.roomsReserved, Global.transaction.MaDoan);
                Global.roomsReserved.Clear();
                Global.roomsChoosen.Clear();
                listRoomChoosen.Items.Refresh();
                listRoomOrdered.Items.Refresh();
                alert_success.Visibility = Visibility.Visible;
                dispatcherTimer.Start();
                noRoomOrdered.Visibility = Visibility.Visible;
                noRoomReserved.Visibility = Visibility.Visible;
            }
            else
            {
                alert_error.Visibility = Visibility.Visible;
                dispatcherTimer.Start();
            }
        }

        private void Window_Loaded_RoomOrdered(object sender, RoutedEventArgs e)
        {

            if (Global.roomsOrdered != null)
            {
                foreach (DetailRoomReservedDTO item in Global.roomsOrdered)
                {
                    if (Global.customersWillOrder != null && Global.customersWillOrder.Count > 0)
                    {
                        var itemToRemove = Global.customersWillOrder.Find(r => r.Id == item.Id_KhachHang);
                        if (itemToRemove != null)
                        {
                            Global.customersWillOrder.Remove(itemToRemove);
                        }
                    }
                }
            }
            listMember.ItemsSource = Global.customersWillOrder;
            listRoomOrdered.ItemsSource = Global.roomsReserved;
            listRoomChoosen.ItemsSource = Global.roomsChoosen;

            if (Global.roomsChoosen.Count == 0)
            {
                noRoomReserved.Visibility = Visibility.Visible;
            }
            else
            {
                noRoomReserved.Visibility = Visibility.Collapsed;
            }
            if (Global.roomsReserved.Count == 0)
            {
                noRoomOrdered.Visibility = Visibility.Visible;
            }
            else
            {
                noRoomOrdered.Visibility = Visibility.Collapsed;
            }
        }

        private void addPersonToRoom(object sender, RoutedEventArgs e)
        {
            if (listRoomChoosen.SelectedItems.Count > 0 && listMember.SelectedValue != null)
            {
                RoomDTO tmp = (RoomDTO)listRoomChoosen.SelectedItems[0];

                DetailReservedDTO tempDetailReserved = new DetailReservedDTO();
                tempDetailReserved.MaKhachHang = listMember.SelectedValue.ToString();
                tempDetailReserved.HoTen = listMember.Text;
                tempDetailReserved.MaPhong = tmp.Id;
                tempDetailReserved.NgayBatDau = Global.transaction.NgayBatDau;
                tempDetailReserved.NgayKetThuc = Global.transaction.NgayKetThuc;

                Global.roomsReserved.Add(tempDetailReserved);

                listRoomOrdered.Items.Refresh();
                noRoomOrdered.Visibility = Visibility.Collapsed;

                var itemToRemove = Global.customersWillOrder.Find(r => r.Id == listMember.SelectedValue.ToString());
                if (itemToRemove != null)
                {
                    Global.customersWillOrder.Remove(itemToRemove);
                }
                listMember.Items.Refresh();
            }
            addPersonToRoom_name.IsEnabled = false;
        }

        private void removePerSonInRoom(object sender, RoutedEventArgs e)
        {
            if (listRoomOrdered.SelectedItems.Count > 0)
            {
                DetailReservedDTO tmp = (DetailReservedDTO)listRoomOrdered.SelectedItems[0];
                var itemToAdd = Global.customers.Find(r => r.Id == tmp.MaKhachHang);
                if (itemToAdd != null)
                {
                    Global.customersWillOrder.Add(itemToAdd);
                }
                listMember.Items.Refresh();
                var itemRoomToRemove = Global.roomsReserved.Find(r => r.MaKhachHang == tmp.MaKhachHang);
                if (itemRoomToRemove != null)
                {
                    Global.roomsReserved.Remove(itemRoomToRemove);
                }
                listRoomOrdered.Items.Refresh();
                if (listRoomOrdered.Items.Count == 0)
                {
                    noRoomOrdered.Visibility = Visibility.Visible;
                }  
            }
            removePerSonInRoom_name.IsEnabled = false;
        }

        private void selectItemRoomOrdered(object sender, MouseButtonEventArgs e)
        {
            removePerSonInRoom_name.IsEnabled = true;
        }

        private void selectItemRoom(object sender, MouseButtonEventArgs e)
        {
            if (listMember.SelectedValue != null)
            {
                addPersonToRoom_name.IsEnabled = true;
            }
        }

        private void listMember_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listRoomChoosen.SelectedItems.Count > 0)
            {
                addPersonToRoom_name.IsEnabled = true;
            }
        }
    }
}
