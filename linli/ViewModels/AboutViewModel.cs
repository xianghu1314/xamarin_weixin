using System;
using System.Windows.Input;
using linli.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace linli.ViewModels
{
    public class AboutViewModel : BaseViewModel<User>
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}