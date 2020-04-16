using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CashRegister;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        private double total = 0.0;
        public TransactionControl(Order or)
        {
            total += or.Subtotal;
            total += or.Subtotal * 0.16;
            InitializeComponent();
            TotalBlock.Text = total.ToString("C");
        }

        private void CancelTrans_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order or)
            {
                var wind = this.FindAncestor<MainWindow>();
                wind.Content = new OrderControl();
            }
        }

        private void PayCredit_Click(object sender, RoutedEventArgs e)
        {
            Order or = (Order)this.DataContext;
            var card = new CardTerminal();
            ResultCode res = card.ProcessTransaction(total);
            if(res == ResultCode.Success)
            {
                var pr = new ReceiptPrinter();
                DateTime date = DateTime.Now;
                string rec = ("Order: " + or.OrderNumber + " " + date.ToString() + " " + ReceiptHelper(or) + "Subtotal: " + or.Subtotal.ToString("C") + 
                    " Total: " + ((or.Subtotal * 0.16 + or.Subtotal).ToString("C")) + " Credit");
                pr.Print(rec);
                var wind = this.FindAncestor<MainWindow>();
                wind.Content = new OrderControl();
            }
            else if(res == ResultCode.InsufficentFunds)
            {
                ErrorBox.Text = "Insufficient Funds on Card.";
            }
            else if(res == ResultCode.ReadError)
            {
                ErrorBox.Text = "Card Read Error, Try Again.";
            }
            else if(res == ResultCode.CancelledCard)
            {
                ErrorBox.Text = "Card Has Been Cancelled.";
            }
            else if(res == ResultCode.UnknownErrror)
            {
                ErrorBox.Text = "Unknown Error Occured.";
            }
        }


        private void PayCash_Click(object sender, RoutedEventArgs e)
        {
            Order or = (Order)this.DataContext;
            var wind = this.FindAncestor<MainWindow>();
            var temp = new CashPayment(total, wind);
            temp.DataContext = or;
            Container.Child = temp;
        }

        /// <summary>
        /// Method used to convert items in order into a single string
        /// </summary>
        /// <param name="or">The order to get items from</param>
        /// <returns>A string with all items from order</returns>
        private string ReceiptHelper(Order or)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in or.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
                sb.Append(item.Price.ToString("C"));
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
