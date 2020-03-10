using System;
using linli.Models;
using linli.Utils;
using Xamarin.Forms;

namespace linli.CustemViews
{
    public partial class ChatRecordItem : ContentView
    {
        protected Double FontSizeMicro;
        protected Double FontSizeSmall;
        private Message message;
        public ChatRecordItem(Message message)
        {
            InitializeComponent();
            this.message = message;
            FontSizeMicro = Device.GetNamedSize(NamedSize.Micro, typeof(Xamarin.Forms.Label));
            FontSizeSmall = Device.GetNamedSize(NamedSize.Small, typeof(Xamarin.Forms.Label));
            this.InitializeView();
        }
        public string TimeFormat(DateTime datetime) {
            var day = (datetime - DateTime.Now).Days ;
            var minute = (datetime - DateTime.Now).Minutes;
            if (day > 2)
            {
                return datetime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else if (day>1)
            {
                return datetime.ToString("昨天HH:mm:ss");
            }
            else
            {
                if (minute > 1 && minute < 10)
                {
                    return datetime.ToString(minute.ToString() + "分钟以前");
                }
                else if (minute < 1)
                {
                    return datetime.ToString("刚刚");
                }
                else
                {
                    return datetime.ToString("HH:mm:ss");
                }
            }
            
        }
        private void InitializeView()
        {
            if (this.message.MessageType == MessageType.Text)
            {
                if (this.message.IsMySelf) // 别人发给我的
                {
                    Content = new StackLayout()
                    {
                        Margin = new Thickness(10),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.End,
                        Children = {
                            new StackLayout() {
                                Orientation=StackOrientation.Vertical,
                                Children={
                                    new Label{Text=this.message.FromUser.Name,HorizontalOptions=LayoutOptions.End,FontSize=FontSizeMicro,TextColor=Color.FromHex("#555")},
                                    new Frame()
                                    {
                                        Padding=0,
                                        CornerRadius=10,
                                        BackgroundColor=Color.FromHex("#abe650"),
                                        Content =new Label{Text=this.message.Content,HorizontalOptions=LayoutOptions.End,FontSize=FontSizeSmall,BackgroundColor=Color.White,Padding=new Thickness(6) },
                                    },
                                    new Label{Text=this.TimeFormat(this.message.CreateTime),HorizontalOptions=LayoutOptions.End,FontSize=FontSizeMicro,TextColor=Color.FromHex("#888")},
                                }
                            },
                            new Image{ HeightRequest = 40, WidthRequest = 40,HorizontalOptions=LayoutOptions.End,VerticalOptions=LayoutOptions.Start ,  Source= this.message.FromUser.HeadImgUrl },
                        }
                    };

                }
                else
                {
                    Content = new StackLayout()
                    {
                        Margin = new Thickness(10),
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Image{ HeightRequest = 40, WidthRequest = 40,HorizontalOptions=LayoutOptions.Start,VerticalOptions=LayoutOptions.Start , Source= this.message.FromUser.HeadImgUrl },
                            new StackLayout() {
                                Orientation=StackOrientation.Vertical,
                                HorizontalOptions=LayoutOptions.Start,
                                Children={
                                    new Label{Text=this.message.FromUser.Name,FontSize=FontSizeMicro,TextColor=Color.FromHex("#555")},
                                    new Frame()
                                    {
                                        Padding=0,
                                        CornerRadius=10,
                                        BackgroundColor=Color.White,
                                        Content =new Label{Text=this.message.Content,FontSize=FontSizeSmall,BackgroundColor=Color.White,Padding=new Thickness(6) },
                                    },
                                    new Label{Text=this.TimeFormat(this.message.CreateTime),FontSize=FontSizeMicro,TextColor=Color.FromHex("#888")},
                                }
                            },
                        }
                    };
                }
            }
            else if (this.message.MessageType == MessageType.Image)
            {
                if (this.message.IsMySelf) // 别人发给我的
                {
                    Content = new StackLayout()
                    {
                        Margin = new Thickness(10),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.End,
                        Children = {
                            new StackLayout() {
                                Orientation=StackOrientation.Vertical,
                                Children={
                                    new Label{Text=this.message.FromUser.Name,HorizontalOptions=LayoutOptions.End,FontSize=FontSizeMicro,TextColor=Color.FromHex("#555")},
                                    new Frame()
                                    {
                                        Padding=0,
                                        CornerRadius=10,
                                        BackgroundColor=Color.FromHex("#abe650"),
                                        Content =new Image{Source=this.message.Content,IsOpaque=true,WidthRequest=App.ScreenWidth*0.6,Aspect=Aspect.AspectFit,HorizontalOptions=LayoutOptions.End,BackgroundColor=Color.White },
                                    },
                                    new Label{Text=this.TimeFormat(this.message.CreateTime),HorizontalOptions=LayoutOptions.End,FontSize=FontSizeMicro,TextColor=Color.FromHex("#888")},
                                }
                            },
                            new Image{ HeightRequest = 40, WidthRequest = 40,HorizontalOptions=LayoutOptions.End,VerticalOptions=LayoutOptions.Start , Source= this.message.FromUser.HeadImgUrl },
                        }
                    };

                }
                else
                {
                    Content = new StackLayout()
                    {
                        Margin = new Thickness(10),
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Image{ HeightRequest = 40, WidthRequest = 40,HorizontalOptions=LayoutOptions.Start,VerticalOptions=LayoutOptions.Start , Source= this.message.FromUser.HeadImgUrl },
                            new StackLayout() {
                                Orientation=StackOrientation.Vertical,
                                HorizontalOptions=LayoutOptions.Start,
                                Children={
                                    new Label{Text=this.message.FromUser.Name,FontSize=FontSizeMicro,TextColor=Color.FromHex("#555")},
                                    new Frame()
                                    {
                                        Padding=0,
                                        CornerRadius=10,
                                        Content =new Image{Source=this.message.Content,IsOpaque=true,WidthRequest=App.ScreenWidth*0.6,Aspect=Aspect.AspectFit,HorizontalOptions=LayoutOptions.End,BackgroundColor=Color.White },
                                    },
                                    new Label{Text=this.TimeFormat(this.message.CreateTime),FontSize=FontSizeMicro,TextColor=Color.FromHex("#888")},
                                }
                            },
                        }
                    };
                }
            }
            else if (this.message.MessageType == MessageType.Audio)
            {

            }
            else if (this.message.MessageType == MessageType.Video)
            {
                //blob: https://www.bilibili.com/94c6e2e0-bfef-4dd6-aba7-a4b5f2907d7c
            }
            else if (this.message.MessageType == MessageType.File)
            {

            }
            else
            {

            }

        }
    }
}
