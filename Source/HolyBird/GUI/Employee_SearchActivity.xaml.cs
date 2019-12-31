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
            tempTransactions.Add(new ActivityDTO { Id = "123", MaDoan = "34567", TrangThai = "waiting" });
            tempTransactions.Add(new ActivityDTO { Id = "1243", MaDoan = "324567", TrangThai = "received" });
            tempTransactions.Add(new ActivityDTO { Id = "1253", MaDoan = "314567", TrangThai = "waiting" });
            tempTransactions.Add(new ActivityDTO { Id = "1263", MaDoan = "346567", TrangThai = "paid" });
            tempTransactions.Add(new ActivityDTO { Id = "1273", MaDoan = "374567", TrangThai = "received" });
            tempTransactions.Add(new ActivityDTO { Id = "122133", MaDoan = "34567", TrangThai = "received" });
            tempTransactions.Add(new ActivityDTO { Id = "1243123123", MaDoan = "32452167", TrangThai = "paid" });
            tempTransactions.Add(new ActivityDTO { Id = "1289876675", MaDoan = "31456327", TrangThai = "paid" });
            tempTransactions.Add(new ActivityDTO { Id = "127674463", MaDoan = "34652e67", TrangThai = "paid" });
            tempTransactions.Add(new ActivityDTO { Id = "126663373", MaDoan = "3745d1s67", TrangThai = "paid" });
            InitializeComponent();
        }

        private void cancelRoom(object sender, RoutedEventArgs e)
        {

        }

        private void AcceptRoom(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_Transactions(object sender, RoutedEventArgs e)
        {
            listTransaction.ItemsSource = tempTransactions;
        }

        private void selectItem(object sender, MouseButtonEventArgs e)
        {
            if (listTransaction.SelectedItems.Count > 0)
            {
                ActivityDTO item = (ActivityDTO)listTransaction.SelectedItems[0];
                if (item.TrangThai == "waiting")
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
                case "received":
                    return "Đã nhận phòng";
                case "paid":
                    return "Đã thanh toán";
            }
            return "Chưa nhận phòng";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case "received":
                    return "Đã nhận phòng";
                case "paid":
                    return "Đã thanh toán";
            }
            return "Chưa nhận phòng";
        }
    }
}
