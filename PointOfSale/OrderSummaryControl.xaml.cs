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
using PointOfSale.ExtensionMethods;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void ChangedSelect(object sender, SelectionChangedEventArgs args)
        {
            IOrderItem item = ((sender as ListBox).SelectedItem as IOrderItem);
            var orderControl = this.FindAncestor<OrderControl>();
            if(item is AngryChicken)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is BakedBeans)
            {
                var screen = new BakedBeansCustomization(DataContext);
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is ChiliCheeseFries)
            {
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is CornDodgers)
            {
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is CowboyCoffee)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is CowpokeChili)
            {
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is DakotaDoubleBurger)
            {
                var screen = new DakotaDoubleCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is JerkedSoda)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is PanDeCampo)
            {
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is PecosPulledPork)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is RustlersRibs)
            {
                var screen = new RustlersRibsCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is TexasTea)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is TexasTripleBurger)
            {
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is TrailBurger)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if(item is Water)
            {
                var screen = new WaterCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void Removeitem(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem)(sender as Button).DataContext;
            if(DataContext is Order or)
            {
                or.Remove(item);
            }
        }
    }
}
