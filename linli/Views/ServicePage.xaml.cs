using System;
using System.Collections.Generic;
using linli.ViewModels;
using Xamarin.Forms;

namespace linli.Views
{
    public partial class ServicePage : ContentPage
    {
        ServiceViewModel serviceViewModel;
        public ServicePage()
        {
            InitializeComponent();
            BindingContext = serviceViewModel = new ServiceViewModel();
        }
    }
}
