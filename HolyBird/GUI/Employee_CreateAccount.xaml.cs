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
using System.Collections;
using System.Windows.Threading;

namespace GUI
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class Employee_CreateAccount : Page
    {
        List<CustomerInformationDTO> tempMembers = new List<CustomerInformationDTO>();
        private DispatcherTimer dispatcherTimer;
        public Employee_CreateAccount()
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
        private void addMember(object sender, RoutedEventArgs e)
        {
            tempMembers.Add(new CustomerInformationDTO());
            listMember_name.ItemsSource = tempMembers;
            listMember_name.Items.Refresh();
        }
        private void removeMember(object sender, RoutedEventArgs e)
        {
            if (listMember_name.SelectedItems.Count > 0)
            {
                CustomerInformationDTO tmp = (CustomerInformationDTO)listMember_name.SelectedItems[0];
                tempMembers.Remove(tmp);
                listMember_name.Items.Refresh();
            }
        }
        private void saveInformation(object sender, RoutedEventArgs e)
        {
            string madoan = MaDoan_name.Text;
            string ngaybatdau = NgayBatDau_name.Text;
            string ngayketthuc = NgayKetThuc_name.Text;
            string lead_name = HoTenLead_name.Text;
            string lead_idcard = CMNDLead_name.Text;
            if (madoan.Trim().Length > 0 && ngaybatdau.Trim().Length > 0 && ngayketthuc.Trim().Length > 0 && lead_name.Trim().Length > 0 && lead_idcard.Trim().Length > 0)
            {
                List<CustomerInformationDTO> customers = new List<CustomerInformationDTO>();
                customers.Add(new CustomerInformationDTO { HoTen = lead_name, CMND = lead_idcard });
                for (int i = 0; i < listMember_name.Items.Count; i++)
                {
                    CustomerInformationDTO temp = (CustomerInformationDTO)listMember_name.Items[i];
                    customers.Add(temp);
                }
                EmployeeBUS.InsertTransaction(madoan, customers, ngaybatdau, ngayketthuc);
                alert_success.Visibility = Visibility.Visible;
                dispatcherTimer.Start();
            }
            else
            {
                alert_error.Visibility = Visibility.Visible;
                dispatcherTimer.Start();
            }
        }
        private void clearInformation(object sender, RoutedEventArgs e)
        {
            MaDoan_name.Clear();
            HoTenLead_name.Clear();
            CMNDLead_name.Clear();
            tempMembers.Clear();
            listMember_name.Items.Refresh();
            NgayBatDau_name.Text = "";
            NgayKetThuc_name.Text = "";
        }
    }
}
