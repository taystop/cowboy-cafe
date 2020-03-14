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

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }

        private void BirchBeerButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Flavor = SodaFlavor.BirchBeer;
            }
        }

        private void CreamSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Flavor = SodaFlavor.CreamSoda;
            }
        }

        private void OrangeSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        private void RootBeerButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Flavor = SodaFlavor.RootBeer;
            }
        }

        private void SarsparillaButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Size = CowboyCafe.Data.Size.Small;
            }
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is JerkedSoda item)
            {
                item.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda item)
            {
                item.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
