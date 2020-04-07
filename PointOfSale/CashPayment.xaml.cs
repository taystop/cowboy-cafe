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
using CashRegister;
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        private double total = 0;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        private CashDrawer cs;
        private double goal;
        public CashPayment(double g, MainWindow win)
        {
            goal = g;
            InitializeComponent();
            TextTotal.Text = total.ToString("C");
            cs = win.Dr;
        }

        /// <summary>
        /// Helper method that adds bills to the drawer, finds which currency to return as change, and removes them from the drawer
        /// </summary>
        private void DrawerHelp()
        {
            //Backing variables holding the number of each denomination to return as change.  Used for StringBuilder change return.
            int dollarB = 0;
            int twos = 0;
            int fives = 0;
            int tens = 0;
            int twentys = 0;
            int fiftys = 0;
            int hundreds = 0;
            int dollarC = 0;
            int halfD = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennys = 0;

            //The target amount of change to return to customer
            double change = Total - goal;
            bool insChange = false;

            //Adding bills from customer to drawer.
            if(TextOnes.Text != "")
                cs.AddBill(Bills.One, Convert.ToInt32(TextOnes.Text));
            if (TextTwos.Text != "")
                cs.AddBill(Bills.Two, Convert.ToInt32(TextTwos.Text));
            if (TextFives.Text != "")
                cs.AddBill(Bills.Five, Convert.ToInt32(TextFives.Text));
            if (TextTens.Text != "")
                cs.AddBill(Bills.Ten, Convert.ToInt32(TextTens.Text));
            if (TextTwentys.Text != "")
                cs.AddBill(Bills.Twenty, Convert.ToInt32(TextTwentys.Text));
            if (TextFiftys.Text != "")
                cs.AddBill(Bills.Fifty, Convert.ToInt32(TextFiftys.Text));
            if (TextHundreds.Text != "")
                cs.AddBill(Bills.Hundred, Convert.ToInt32(TextHundreds.Text));
            if (TextPennys.Text != "")
                cs.AddCoin(Coins.Penny, Convert.ToInt32(TextPennys.Text));
            if (TextNickels.Text != "")
                cs.AddCoin(Coins.Nickel, Convert.ToInt32(TextNickels.Text));
            if (TextDimes.Text != "")
                cs.AddCoin(Coins.Dime, Convert.ToInt32(TextDimes.Text));
            if (TextQuarters.Text != "")
                cs.AddCoin(Coins.Quarter, Convert.ToInt32(TextQuarters.Text));
            if (TextHalfDollar.Text != "")
                cs.AddCoin(Coins.HalfDollar, Convert.ToInt32(TextHalfDollar.Text));
            if (TextCoinDollars.Text != "")
                cs.AddCoin(Coins.Dollar, Convert.ToInt32(TextCoinDollars.Text));

            //Finding the number of each denomination to return to equal exact change based on the change variable calculated above.
            while (!(change < .01))
            {
                if (change >= 100.00 && cs.Hundreds > 0)
                {
                    change -= 100.00;
                    cs.RemoveBill(Bills.Hundred, 1);
                    hundreds++;
                }
                else if (change >= 50.00 && cs.Fifties > 0)
                {
                    change -= 50.00;
                    cs.RemoveBill(Bills.Fifty, 1);
                    fiftys++;
                }
                else if (change >= 20.0 && cs.Twenties > 0)
                {
                    change -= 20.00;
                    cs.RemoveBill(Bills.Twenty, 1);
                    twentys++;
                }
                else if (change >= 10.0 && cs.Tens > 0)
                {
                    change -= 10.00;
                    cs.RemoveBill(Bills.Ten, 1);
                    tens++;
                }
                else if (change >= 5.0 && cs.Fives > 0)
                {
                    change -= 5.00;
                    cs.RemoveBill(Bills.Five, 1);
                    fives++;
                }
                else if (change >= 2.0 && cs.Twos > 0)
                {
                    change -= 2.00;
                    cs.RemoveBill(Bills.Two, 1);
                    twos++;
                }
                else if (change >= 1.0 && cs.Ones > 0)
                {
                    change -= 1.0;
                    cs.RemoveBill(Bills.One, 1);
                    dollarB++;
                }
                else if (change >= 1.0 && cs.Dollars > 0)
                {
                    change -= 1.0;
                    cs.RemoveCoin(Coins.Dollar, 1);
                    dollarC++;
                }
                else if (change >= .5 && cs.HalfDollars > 0)
                {
                    change -= .5;
                    cs.RemoveCoin(Coins.HalfDollar, 1);
                    halfD++;
                }
                else if (change > .25 && cs.Quarters > 0)
                {
                    change -= .25;
                    cs.RemoveCoin(Coins.Quarter, 1);
                    quarters++;
                }
                else if(change >= .1 && cs.Dimes > 0)
                {
                    change -= .1;
                    cs.RemoveCoin(Coins.Dime, 1);
                    dimes++;
                }
                else if(change >= .05 && cs.Nickels > 0)
                {
                    change -= .05;
                    cs.RemoveCoin(Coins.Nickel, 1);
                    nickels++;
                }
                else if(change < .05 && cs.Pennies > 0)
                {
                    change -= .01;
                    cs.RemoveCoin(Coins.Penny, 1);
                    pennys++;
                }
                else
                {
                    //There is not enough of each denomination to complete the transaction so I'll ask the worker to restock the register.
                    TextChange.Text = "Not enough Money in Register please refill.";
                    DoneBtn.IsEnabled = true;
                    insChange = true;
                    break;
                }
            }

            if (!insChange)
            {
                //Creating the string to display to the worker regarding customer change to return
                StringBuilder sb = new StringBuilder();
                if (dollarB > 0)
                {
                    sb.Append(dollarB);
                    sb.Append("x Dollar Bill(s). ");
                }
                if (twos > 0)
                {
                    sb.Append(twos);
                    sb.Append("x 2 Dollar Bill(s). ");
                }
                if (fives > 0)
                {
                    sb.Append(fives);
                    sb.Append("x 5 Dollar Bill(s). ");
                }
                if (tens > 0)
                {
                    sb.Append(tens);
                    sb.Append("x 10 Dollar Bill(s). ");
                }
                if (twentys > 0)
                {
                    sb.Append(twentys);
                    sb.Append("x 20 Dollar Bill(s). ");
                }
                if (fiftys > 0)
                {
                    sb.Append(fiftys);
                    sb.Append("x 50 Dollar Bill(s). ");
                }
                if (hundreds > 0)
                {
                    sb.Append(hundreds);
                    sb.Append("x 100 Dollar Bill(s). ");
                }
                if (halfD > 0)
                {
                    sb.Append(halfD);
                    sb.Append("x Half Dollars. ");
                }
                if (quarters > 0)
                {
                    sb.Append(quarters);
                    sb.Append("x Quarters. ");
                }
                if (dimes > 0)
                {
                    sb.Append(dimes);
                    sb.Append("x Dimes. ");
                }
                if (nickels > 0)
                {
                    sb.Append(nickels);
                    sb.Append("x Nickels. ");
                }
                if (pennys > 0)
                {
                    sb.Append(pennys);
                    sb.Append("x Pennys. ");
                }
                TextChange.Text = sb.ToString();

                //Disabling Input textboxes to indicate that transaction is over.  Also enables the Done button to finish transaction.
                DoneBtn.IsEnabled = true;
                TextOnes.IsEnabled = false;
                TextTwos.IsEnabled = false;
                TextFives.IsEnabled = false;
                TextTens.IsEnabled = false;
                TextTwentys.IsEnabled = false;
                TextFiftys.IsEnabled = false;
                TextHundreds.IsEnabled = false;
                TextCoinDollars.IsEnabled = false;
                TextHalfDollar.IsEnabled = false;
                TextQuarters.IsEnabled = false;
                TextDimes.IsEnabled = false;
                TextNickels.IsEnabled = false;
                TextPennys.IsEnabled = false;
            }
        }


        private void TextOnes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextOnes.Text != "")
            {
                int num = Convert.ToInt32(TextOnes.Text);
                total += num;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextTwos_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TextTwos.Text != "")
            {
                int num = Convert.ToInt32(TextTwos.Text);
                total += num * 2;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextFives_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TextFives.Text != "")
            {
                int num = Convert.ToInt32(TextFives.Text);
                total += num * 5;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextTens_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TextTens.Text != "")
            {
                int num = Convert.ToInt32(TextTens.Text);
                total += num * 10;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextTwentys_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TextTwentys.Text != "")
            {
                int num = Convert.ToInt32(TextTwentys.Text);
                total += num * 20;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextFiftys_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TextFiftys.Text != "")
            {
                int num = Convert.ToInt32(TextFiftys.Text);
                total += num * 50;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextHundreds_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TextHundreds.Text != "")
            {
                int num = Convert.ToInt32(TextHundreds.Text);
                total += num * 100;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextPennys_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextPennys.Text != "")
            {
                int num = Convert.ToInt32(TextPennys.Text);
                total += num * .01;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextNickels_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextNickels.Text != "")
            {
                int num = Convert.ToInt32(TextNickels.Text);
                total += num * .05;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextDimes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextDimes.Text != "")
            {
                int num = Convert.ToInt32(TextDimes.Text);
                total += num * .10;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextQuarters_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextQuarters.Text != "")
            {
                int num = Convert.ToInt32(TextQuarters.Text);
                total += num * .25;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextHalfDollar_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextHalfDollar.Text != "")
            {
                int num = Convert.ToInt32(TextHalfDollar.Text);
                total += num * .50;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void TextCoinDollars_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextCoinDollars.Text != "")
            {
                int num = Convert.ToInt32(TextCoinDollars.Text);
                total += num;
                TextTotal.Text = total.ToString("C");
                if (total >= goal) DrawerHelp();
            }
        }

        private void DoneBtn_Click(object sender, RoutedEventArgs e)
        {
            var or = (Order)this.DataContext;
            var pr = new ReceiptPrinter();
            DateTime date = DateTime.Now;
            string rec = ("Order: " + or.OrderNumber + " " + date.ToString() + " " + ReceiptHelper(or) + "Subtotal: " + or.Subtotal.ToString("C") + " Total: " + ((or.Subtotal * 0.16 + or.Subtotal).ToString("C")) + " Cash");
            if (rec.Length <= 60)
                pr.Print(rec);
            var wind = this.FindAncestor<MainWindow>();
            wind.Dr = cs;
            wind.Content = new OrderControl();
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