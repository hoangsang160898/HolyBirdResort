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
        List<BillChildDTO> tempBillChildren = new List<BillChildDTO>();
        public Bill()
        {
            InitializeComponent();
        }

        private void Window_Loaded_Bill(object sender, RoutedEventArgs e)
        {
            tempBillChildren = BillChildBUS.LoadBillChild(Global.IdTransactionWhenPayment);
            listBillChildren.ItemsSource = tempBillChildren;
            TransactionBUS.UpdateSumMoney(Global.IdTransactionWhenPayment);
            TransactionDTO billResult = TransactionBUS.GetTransaction(Global.IdTransactionWhenPayment);
            sumMoney_name.Text = billResult.TongTien;
            IdTransaction_name.Text = billResult.Id;
            IdMaDoan_name.Text = billResult.MaDoan;
            nameLeader_name.Text = TransactionBUS.GetNameLeader(billResult.Id_DaiDien);
        }

        private void PayBill(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listBillChildren.Items.Count; i++)
            {
                BillChildDTO temp = (BillChildDTO)listBillChildren.Items[i];
                BillChildBUS.RemoveBillChild(temp.Id_ChiTietGiaoDich);
            }
            payBill_name.IsEnabled = false;
            payBill_name.Content = "Đã thanh toán";
            Global.IdTransactionWhenPayment = "";
        }
    }
}
