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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new AngryChicken();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new AngryChickenCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new CowpokeChili();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }
    }
}
