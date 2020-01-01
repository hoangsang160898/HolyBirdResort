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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class Employee_CreateAccount : Page
    {
        List<CustomerDTO> tempMembers = new List<CustomerDTO>();

        public Employee_CreateAccount()
        {
            InitializeComponent();
        }
        private void addMember(object sender, RoutedEventArgs e)
        {
            tempMembers.Add(new CustomerDTO());
            listMember.ItemsSource = tempMembers;
            listMember.Items.Refresh();
        }
        private void removeMember(object sender, RoutedEventArgs e)
        {
            if (listMember.SelectedItems.Count > 0)
            {
                CustomerDTO tmp = (CustomerDTO)listMember.SelectedItems[0];
                tempMembers.Remove(tmp);
                listMember.Items.Refresh();
            }
        }
        private void saveInformation(object sender, RoutedEventArgs e)
        {

        }
    }
}
