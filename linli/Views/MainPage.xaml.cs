using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace linli.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            BarBackgroundColor = Color.FromHex("#f7f7f7");
            //选中的tab颜色
            BarTextColor = Color.FromHex("#61c06e");
            SelectedTabColor = Color.FromHex("#61c06e");
            //为选中的tab颜色
            UnselectedTabColor = Color.FromHex("#343434");
        }
    }
}