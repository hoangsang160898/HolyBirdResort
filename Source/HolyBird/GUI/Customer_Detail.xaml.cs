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
        public Customer_Detail()
        {
            InitializeComponent();
        }

        private void Window_Loaded_DetailTransaction(object sender, RoutedEventArgs e)
        {
            List<DetailRoomReservedDTO> listDetail = DetailRoomReservedBUS.LoadDetailRoomReserved(Global.account.Id_GiaoDich);
            if (listDetail == null)
            {
                noDetail.Visibility = Visibility.Visible;
            }
            else
            {
                noDetail.Visibility = Visibility.Collapsed;
                listRoomOrder.ItemsSource = listDetail;
            }
        }
    }
}
