using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductionMonitor.Views;

namespace ProductionMonitor.ViewModels
{
    public partial class ProductStatusVM : ObservableObject
    {
        [ObservableProperty]
        private string productName = string.Empty;

        [ObservableProperty]
        private int quantity;
        
        [ObservableProperty]
        private int defectiveQuantity;

        [ObservableProperty]
        private string productImage = string.Empty;

        public ProductStatusVM()
        {
            // Default constructor
        }

        public ProductStatusVM(string productName, int quantity, int defectiveQuantity, string productImage)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.defectiveQuantity = defectiveQuantity;
            this.productImage = productImage;
        }

        
        //[RelayCommand]
        //private void UpdateStatus(string newStatus)
        //{
        //    Status = newStatus;
        //}
    }
}
