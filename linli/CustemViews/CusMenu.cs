using System;
using System.Collections.Generic;
using Xamarin.Forms;
using linli.Models;
using Menu = linli.Models.Menu;

namespace linli.CustemViews
{
    public class  CusMenu : FlexLayout
    {
        public static readonly BindableProperty MenusProperty =
          BindableProperty.Create("Menus", typeof(IEnumerable<Menu>), typeof(NativeListView), new List<Menu>(), defaultBindingMode: BindingMode.TwoWay);
        public IEnumerable<Menu> Menus
        {
            get { return (IEnumerable<Menu>)GetValue(MenusProperty); }
            set {
                SetValue(MenusProperty, value);
                MenuRender();
            }
        }
        protected void MenuRender()
        {
                foreach (var item in Menus)
                {
                    var stackLayout = new StackLayout
                    {
                        HeightRequest = 50,
                        Margin = new Thickness(0, 5),
                        Children ={
                        new ImageButton(){
                            Aspect=Aspect.AspectFill,
                            BorderWidth=0,
                            HorizontalOptions=LayoutOptions.Center,
                            HeightRequest=30,
                            WidthRequest=30,
                            BackgroundColor=Color.White,
                            Source=item.Image
                        },
                        new Label()
                        {
                            Margin=0,
                            Padding=0,
                            FontSize=12,
                            HorizontalTextAlignment=TextAlignment.Center,
                            LineHeight=20,
                            HeightRequest=20,
                            Text = item.Title
                        }
                    }
                    };
                    //<StackLayout HeightRequest="50" Margin="0,5" Padding="0" FlexLayout.Basis="20%">
                    //                <ImageButton Margin="0" Padding="0" Aspect="AspectFill" BorderWidth="0" HorizontalOptions="Center" HeightRequest="30" WidthRequest="30"  BackgroundColor="White"  Source="{Binding .[0].Image}"></ImageButton>
                    //                <Label Margin="0" Padding="0" FontSize="12" HorizontalTextAlignment="Center" LineHeight="20" HeightRequest="20" Text="{Binding .[0].Title}"></Label>
                    //            </StackLayout>
                    this.Children.Add(stackLayout);
                }
        }
    }
}

