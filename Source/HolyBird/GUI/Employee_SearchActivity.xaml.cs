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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Employee_SearchActivity : Page
    {
        List<ActivityDTO> tempTransactions = new List<ActivityDTO>();
        public Employee_SearchActivity()
        {
            InitializeComponent();
        }

        private void cancelRoom(object sender, RoutedEventArgs e)
        {
            if (listTransaction.Items.Count > 0)
            {
                ActivityDTO item = (ActivityDTO)listTransaction.SelectedItems[0];
                ActivityBUS.CancelRoom(item.Id);
            }
            tempTransactions = ActivityBUS.LoadActivities();
            listTransaction.ItemsSource = tempTransactions;
            listTransaction.Items.Refresh();
        }

        private void AcceptRoom(object sender, RoutedEventArgs e)
        {
            if (listTransaction.Items.Count > 0)
            {
                ActivityDTO item = (ActivityDTO)listTransaction.SelectedItems[0];
                ActivityBUS.AcceptRoom(item.MaDoan);
            }
            tempTransactions = ActivityBUS.LoadActivities();
            listTransaction.ItemsSource = tempTransactions;
            listTransaction.Items.Refresh();
        }

        private void Window_Loaded_Transactions(object sender, RoutedEventArgs e)
        {
            tempTransactions = ActivityBUS.LoadActivities();
            listTransaction.ItemsSource = tempTransactions;
        }

        private void selectItem(object sender, MouseButtonEventArgs e)
        {
            if (listTransaction.SelectedItems.Count > 0)
            {
                ActivityDTO item = (ActivityDTO)listTransaction.SelectedItems[0];
                if (item.TrangThai == "Đặt trước")
                {
                    cancelRoom_name.IsEnabled = true;
                    acceptRoom_name.IsEnabled = true;
                } else {
                    cancelRoom_name.IsEnabled = false;
                    acceptRoom_name.IsEnabled = false;
                }
            }
        }
    }
    public class StatusOfRoomConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case "Trống":
                    return "Chưa đặt phòng";
                case "Đang sử dụng":
                    return "Đã nhận phòng";
            }
            return "Đã đặt trước";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case "Trống":
                    return "Chưa đặt phòng";
                case "Đang sử dụng":
                    return "Đã nhận phòng";
            }
            return "Đã đặt trước";
        }
    }
}
