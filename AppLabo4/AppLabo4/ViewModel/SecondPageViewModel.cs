using AppLabo4.Model;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace AppLabo4.ViewModel
{
    public class SecondPageViewModel
    {
        private INavigationService _navigationService;
        public Student SelectedStudent { get; set; }


        public SecondPageViewModel()
        {

        }
        [PreferredConstructor]
        public SecondPageViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student)e.Parameter;
        }

    }
}
