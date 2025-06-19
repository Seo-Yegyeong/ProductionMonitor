using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProductionMonitor.ViewModels
{
    public partial class StartVM : ObservableObject
    {
        [RelayCommand]
        public void StartButton()
        {
            // Logic to start the production monitor
            MessageBox.Show("Production Monitor Started");
        }
    }
}
