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

            if (DataContext is Order data)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
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
            var item = new DakotaDoubleBurger();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new DakotaDoubleCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new PecosPulledPork();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new PecosPulledPorkCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new RustlersRibs();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new RustlersRibsCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new TexasTripleBurger();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TexasTripleBurgerCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new TrailBurger();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TrailBurgerCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new BakedBeans();
            var orderControl = this.FindAncestor<OrderControl>();
            
            if (DataContext is Order data)
            {
                var screen = new BakedBeansCustomization(data);
                screen.DataContext = item;
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new ChiliCheeseFries();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new ChiliCheeseFriesCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new CornDodgers();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CornDodgersCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new PanDeCampo();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new PanDeCampoCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new CowboyCoffee();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CowboyCoffeeCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new JerkedSoda();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new JerkedSodaCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new TexasTea();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TexasTeaCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var item = new Water();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new WaterCustomization();
            screen.DataContext = item;
            if (DataContext is Order data)
            {
                data.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
