﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProductionMonitor.ViewModels
{
    public partial class StartVM : ObservableObject
    {
        [RelayCommand]
        private void StartButton()
        {
            // Logic to start the production monitor
            MessageBox.Show("Production Monitor Started");
            //Uri uri = new Uri("HomeWindow.xaml", UriKind.Relative);
            //NavigationService NService;
            //NService.Navigate(uri);
        }
    }
}
