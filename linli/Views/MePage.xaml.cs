using System;
using System.Collections.Generic;
using linli.ViewModels;
using Xamarin.Forms;

namespace linli.Views
{
    public partial class MePage : ContentPage
    {
        MeViewModel meViewModel;
        public MePage()
        {
            
            InitializeComponent();
            BindingContext= meViewModel = new MeViewModel();
        }
    }
}
