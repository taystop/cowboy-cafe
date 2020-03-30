﻿using System;
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
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        private Order or;
        public BakedBeansCustomization(object d)
        {
            or = (Order)d;
            InitializeComponent();
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is BakedBeans item)
            {
                or.SubHelp(item, CowboyCafe.Data.Size.Small);
            }
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BakedBeans item)
            {
                or.SubHelp(item, CowboyCafe.Data.Size.Medium);
            }
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BakedBeans item)
            {
                or.SubHelp(item, CowboyCafe.Data.Size.Large);
            }
        }
    }
}
