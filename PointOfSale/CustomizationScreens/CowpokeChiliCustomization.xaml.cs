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
    /// Interaction logic for CowpokeChiliCustomization.xaml
    /// </summary>
    public partial class CowpokeChiliCustomization : UserControl
    {
        private Order or;
        public CowpokeChiliCustomization(Order order)
        {
            or = order;
            InitializeComponent();
        }
    }
}
