﻿using System;
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

namespace ProductionMonitor.Views
{
    /// <summary>
    /// Interaction logic for ProductStatusWindow.xaml
    /// </summary>
    public partial class ProductStatusWindow : Window
    {
        public ProductStatusWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.ProductStatusVM();
        }

        private void BackToHome_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new HomeWindow());
        }
    }
}
