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
    /// Interaction logic for Customer_Detail.xaml
    /// </summary>
    public partial class Customer_Detail : Page
    {
        List<DetailRoomReservedDTO> tempRoomReserved = new List<DetailRoomReservedDTO>();
        public Customer_Detail()
        {
            tempRoomReserved.Add(new DetailRoomReservedDTO { MaDoan = "123123", HoTen = "Nguyen Thi Thu Quyen", CMND = "3123123", MaPhong = "das1", NgayBatDau = "1/1/2020", NgayKetThuc = "10/1/2020", DonGia = "750000", ThanhTien = "7500000" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { MaDoan = "1231223", HoTen = "b", CMND = "3123123", MaPhong = "das1", NgayBatDau = "1/1/2020", NgayKetThuc = "10/1/2020", DonGia = "750000", ThanhTien = "7500000" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { MaDoan = "1231123", HoTen = "c", CMND = "3123123", MaPhong = "das1", NgayBatDau = "1/1/2020", NgayKetThuc = "10/1/2020", DonGia = "750000", ThanhTien = "7500000" });
            tempRoomReserved.Add(new DetailRoomReservedDTO { MaDoan = "123d2123", HoTen = "d", CMND = "3123123", MaPhong = "das1", NgayBatDau = "1/1/2020", NgayKetThuc = "10/1/2020", DonGia = "750000", ThanhTien = "7500000" });
            InitializeComponent();
        }

        private void Window_Loaded_DetailTransaction(object sender, RoutedEventArgs e)
        {
            listRoomOrder.ItemsSource = tempRoomReserved;
        }
    }
}
