using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductionMonitor.Views.Modals;

namespace ProductionMonitor.ViewModels
{
    public partial class HomeVM : ObservableObject
    {
        [RelayCommand]
        private void ProductRegistrationModal()
        {
            var modal = new ProductRegistrationModalWindow(); // 별도 Window로 모달 정의
            modal.ShowDialog();
        }
    }
}
