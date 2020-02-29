using System;
using System.Collections.Generic;
using linli.ViewModels;
using Xamarin.Forms;

namespace linli.Views
{
    public partial class ContactsPage : ContentPage
    {
        AttentionViewModel attentionViewModel;
        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = attentionViewModel = new AttentionViewModel();
        }
        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (attentionViewModel.Attentions.Count == 0)
                attentionViewModel.LoadItemsCommand.Execute(null);
        }
    }
}
