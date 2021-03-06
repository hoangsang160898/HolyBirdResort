﻿using System;
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
using System.Windows.Shapes;
using BUS;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for DashboardEmployee.xaml
    /// </summary>
    public partial class DashboardCustomer : Window
    {
        public DashboardCustomer()
        {
            InitializeComponent();
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            GridPrincipal.IsEnabled = false;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            GridPrincipal.IsEnabled = true;
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            switch (index)
            {
                case 0:
                    GridPrincipal.Content = new Customer_SearchRoom();
                    break;
                case 1:
                    GridPrincipal.Content = new Customer_OrderRoom();
                    break;
                case 2:
                    GridPrincipal.Content = new Customer_Detail();
                    break;
                default:
                    break;
            }

        }

        private void MoveCursorMenu(int index)
        {
            GridCursor.Margin = new Thickness(0, (50 + (50 * index)), 0, 0);

        }

        private void Window_Loaded_Customer(object sender, RoutedEventArgs e)
        {
            Global.roomsEmpty = RoomBUS.LoadRoomEmptyAll();
            Global.roomsOrdered = DetailRoomReservedBUS.LoadDetailRoomReserved(Global.account.Id_GiaoDich);
            Global.transaction = TransactionBUS.GetTransaction(Global.account.Id_GiaoDich);
            Global.customers = CustomerBUS.LoadCustomer(Global.account.Id_GiaoDich);
            Global.customersWillOrder = CustomerBUS.LoadCustomer(Global.account.Id_GiaoDich);
        }
    }
}
