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
using BUS;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            //Username: login_username__name
            //Password: login_password__name
            InitializeComponent();
        }
        private void Window_Loaded_Employees(object sender, RoutedEventArgs e)
        {
            Global.employees = EmployeeBUS.LoadEmployees();
        }

        private void login_submit__click(object sender, RoutedEventArgs e)
        {

        }
    }
}
