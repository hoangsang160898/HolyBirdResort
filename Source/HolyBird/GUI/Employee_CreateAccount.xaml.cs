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

namespace GUI
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class Employee_CreateAccount : Page
    {
        List<CustomerInformationDTO> tempMembers = new List<CustomerInformationDTO>();

        public Employee_CreateAccount()
        {
            InitializeComponent();
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
            List<CustomerInformationDTO> customers = new List<CustomerInformationDTO>();
            customers.Add(new CustomerInformationDTO { HoTen = HoTenLead_name.Text, CMND = CMNDLead_name.Text });
            for(int i = 0; i < listMember_name.Items.Count; i++)
            {
                CustomerInformationDTO temp = (CustomerInformationDTO)listMember_name.Items[i];
                customers.Add(temp);
            }
            Console.WriteLine("madoan: " + madoan);
            Console.WriteLine("ngaybatdau: " + ngaybatdau);
            Console.WriteLine("ngayketthuc: " + ngayketthuc);
            Console.WriteLine("soluongcustomers: " + customers.Count.ToString());

            EmployeeBUS.InsertTransaction(madoan, customers, ngaybatdau, ngayketthuc);
        }
    }
}
