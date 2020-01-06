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
        TransactionDTO tempTransaction = new TransactionDTO();
        List<DamagesDTO> pushDamages = new List<DamagesDTO>();

        public Employee_Payment()
        {
            InitializeComponent();
        }

        private void Window_Loaded_Damages(object sender, RoutedEventArgs e)
        {
            listDamages.ItemsSource = tempDamages;
            noTransaction.Visibility = Visibility.Visible;
        }

        private void exportBill(object sender, RoutedEventArgs e)
        {
            if (tempDamages != null)
            {
                pushDamages.Clear();
                for (int i = 0; i < tempDamages.Count; i++)
                {
                    DamagesDTO temp = (DamagesDTO)listDamages.Items[i];
                    if (temp.ChiPhiDenBu != "" && temp.TaiSanThietHai != "")
                    {
                        pushDamages.Add(temp);
                        Console.WriteLine(temp.Id_GiaoDich);
                        Console.WriteLine(temp.Id_Phong);
                        Console.WriteLine(temp.ChiPhiDenBu);
                        Console.WriteLine(temp.TaiSanThietHai);
                        Console.WriteLine("So luong thiet hai: " + pushDamages.Count);
                        tempDamages.Remove(temp);
                        listDamages.Items.Refresh();
                    }                   
                }
                if (pushDamages.Count > 0)
                {
                    foreach (DamagesDTO item in pushDamages)
                    {
                        EmployeeBUS.UpdateDamages(item.Id_Phong, item.Id_GiaoDich, item.TaiSanThietHai, item.ChiPhiDenBu);
                        Console.WriteLine(tempTransaction.Id);
                    }
                }
            }
            Global.IdTransactionWhenPayment = tempTransaction.Id;
            exportBill_name.IsEnabled = false;
            var window = new Bill();
            window.Show();
        }

        private void searchRoomReserved(object sender, RoutedEventArgs e)
        {
            tempDamages.Clear();
            string madoan = searchIdTeam_name.Text;
            tempTransaction = TransactionBUS.SearchTransaction(madoan);
            List<string> tempIdPhong = EmployeeBUS.LoadIdRoomOrdered(tempTransaction.Id);
            int countUpdate = 0;
            if (tempIdPhong != null)
            {
                List<DamagesDTO> damagesUpdated = DamagesBUS.LoadDamages(tempTransaction.Id);
                countUpdate = tempIdPhong.Count;
                if (damagesUpdated != null)
                {
                    foreach (DamagesDTO item in damagesUpdated)
                    {
                        var itemToRemove = tempIdPhong.Find(r => r == item.Id_Phong);
                        if (itemToRemove != null)
                        {
                            tempIdPhong.Remove(itemToRemove);
                        }
                    }
                }
                for (int i = 0; i < tempIdPhong.Count; i++)
                {
                    tempDamages.Add(new DamagesDTO { Id_GiaoDich = tempTransaction.Id, Id_Phong = tempIdPhong[i] });
                }
            }
            listDamages.Items.Refresh();
            if (listDamages.Items.Count > 0)
            {
                noTransaction.Visibility = Visibility.Collapsed;

            }
            else
            {
                noTransaction.Visibility = Visibility.Visible;

            }
            if (countUpdate > 0)
            {
                exportBill_name.IsEnabled = true;
            }
            else
            {
                exportBill_name.IsEnabled = false;
            }
        }
    }
}
