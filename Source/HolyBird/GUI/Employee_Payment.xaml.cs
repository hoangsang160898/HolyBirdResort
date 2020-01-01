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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Employee_Payment : Page
    {
        List<DamagesDTO> tempDamages = new List<DamagesDTO>();
        public Employee_Payment()
        {
            tempDamages.Add(new DamagesDTO {Id_Phong="dasdas" });
            tempDamages.Add(new DamagesDTO { Id_Phong = "das2das"});
            tempDamages.Add(new DamagesDTO { Id_Phong = "dasd1as"});
            tempDamages.Add(new DamagesDTO { Id_Phong = "dasd111das"});
            InitializeComponent();
        }

        private void Window_Loaded_Damages(object sender, RoutedEventArgs e)
        {
            listDamages.ItemsSource = tempDamages;
        }

        private void exportBill(object sender, RoutedEventArgs e)
        {
            var window = new Bill();
            window.Show();
        }

        private void searchRoomReserved(object sender, RoutedEventArgs e)
        {

        }
    }
}
