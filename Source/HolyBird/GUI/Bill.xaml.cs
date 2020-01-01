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
using System.Windows.Shapes;
using DTO;
using BUS;
namespace GUI
{
    /// <summary>
    /// Interaction logic for Bill.xaml
    /// </summary>
    public partial class Bill : Window
    {
        List<BillChildDTO> tempBillChildred = new List<BillChildDTO>();
        public Bill()
        {
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "123123", DonGia = "12312312", ThoiGian = "11", ThanhTien = "12312312" });
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "1223123", DonGia = "123122312", ThoiGian = "10", ThanhTien = "12312312" });
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "123sdd123", DonGia = "123123312", ThoiGian = "1", ThanhTien = "12312312" });
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "1212ww3123", DonGia = "123112312", ThoiGian = "2", ThanhTien = "12312312" });
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "123d123", DonGia = "12312s312", ThoiGian = "1.5", ThanhTien = "12312312" });
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "1212ww3123", DonGia = "123112312", ThoiGian = "2", ThanhTien = "12312312" });
            tempBillChildred.Add(new BillChildDTO { Id_Phong = "123d123", DonGia = "12312s312", ThoiGian = "1.5", ThanhTien = "12312312" });
            InitializeComponent();
        }

        private void Window_Loaded_Bill(object sender, RoutedEventArgs e)
        {
            listBillChildren.ItemsSource = tempBillChildred;
        }

        private void payBill(object sender, RoutedEventArgs e)
        {

        }
    }
}
