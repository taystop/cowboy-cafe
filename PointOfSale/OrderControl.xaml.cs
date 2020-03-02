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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            var data = new Order();
            data.Add(new AngryChicken() { Bread = false, Pickle = false});
            data.Add(new TexasTea() { Ice = false });
            data.Add(new TrailBurger() { Bun = false });
            this.DataContext = data;
        }

        private void CancelOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void CompleteOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
