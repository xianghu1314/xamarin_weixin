using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using linli.CustemViews;
using linli.Models;
using linli.Services;
using linli.ViewModels;
using Xamarin.Forms;

namespace linli.Views
{
    public partial class MessagePage : ContentPage
    {
        MessageViewModel viewModel;
        public MessagePage(MessageViewModel model)
        {
            InitializeComponent();
            BindingContext = viewModel = model;
            //NavigationPage.SetHasNavigationBar(this, true);
        }
        public void AddChatContent(Message message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                ChatRecordItem item = new ChatRecordItem(message);
                this.stackLayout.Children.Add(item);
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.Messages.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
                foreach (var item in viewModel.Messages)
                {
                    AddChatContent(item);
                }
            }
        }

        void btn_OpenActionSheet_Clicked(System.Object sender, System.EventArgs e)
        {
            bottomView.IsVisible = !bottomView.IsVisible;
            btn_OpenActionSheet.Source = bottomView.IsVisible?"close.png":"open.png";
        }
    }
}
