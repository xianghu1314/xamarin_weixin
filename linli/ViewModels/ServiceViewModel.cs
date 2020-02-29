using System;
using System.Collections.ObjectModel;
using Android.Provider;
using linli.Models;
using Xamarin.Forms;

namespace linli.ViewModels
{
    public class ServiceViewModel: BaseViewModel<string>
    {
        public ObservableCollection<string> Xialas { get; set; }
        public ObservableCollection<string> Menus { get; set; }
        public ObservableCollection<Trail> TrailRecords { get; set; }
        

        public ServiceViewModel()
        {
            Title = "我的";
            Xialas = new ObservableCollection<string>
            {
                "中德英伦联邦D区",
                "中德英伦联邦C区",
                "中德英伦联邦A区",
                "中德英伦联邦B区",
            };
            Menus = new ObservableCollection<string>
            {
                "棋牌",
                "饮料",
                "家政",
                "药店",
            };
            TrailRecords = new ObservableCollection<Trail>
            {
                new Trail
                {
                    Id=Guid.NewGuid().ToString(),
                    Content = "今天天气真不错！",
                    CreateUser = new User { Id = Guid.NewGuid().ToString(), Name = "，雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/20.png",CreateTime=DateTime.Now },
                    CreateTime = DateTime.Now,
                    Images = new string[]{"https://img.xiaopiu.com/static/wechat_app/52.png","https://img.xiaopiu.com/static/wechat_app/53.png","https://img.xiaopiu.com/static/wechat_app/54.png","https://img.xiaopiu.com/static/wechat_app/55.png" },
                    Comments = new System.Collections.Generic.List<TrailComment>
                    {
                        new TrailComment
                        {
                            Id=Guid.NewGuid().ToString(),
                            Content="真漂亮",
                            CreateTime=DateTime.Now,
                            CreateUser=new User { Id = Guid.NewGuid().ToString(), Name = "雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/19.png",CreateTime=DateTime.Now },
                        }
                    }
                },
                new Trail
                {
                    Id=Guid.NewGuid().ToString(),
                    Content = "今天天气真不错！",
                    CreateUser = new User { Id = Guid.NewGuid().ToString(), Name = "，雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/20.png",CreateTime=DateTime.Now },
                    CreateTime = DateTime.Now,
                    Images = new string[]{"https://img.xiaopiu.com/static/wechat_app/52.png","https://img.xiaopiu.com/static/wechat_app/53.png","https://img.xiaopiu.com/static/wechat_app/54.png","https://img.xiaopiu.com/static/wechat_app/55.png" },
                    Comments = new System.Collections.Generic.List<TrailComment>
                    {
                        new TrailComment
                        {
                            Id=Guid.NewGuid().ToString(),
                            Content="真漂亮",
                            CreateTime=DateTime.Now,
                            CreateUser=new User { Id = Guid.NewGuid().ToString(), Name = "雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/19.png",CreateTime=DateTime.Now },
                        },
                        new TrailComment
                        {
                            Id=Guid.NewGuid().ToString(),
                            Content="这是哪里啊？",
                            CreateTime=DateTime.Now,
                            CreateUser=new User { Id = Guid.NewGuid().ToString(), Name = "雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/19.png",CreateTime=DateTime.Now },
                        }
                    }
                }
            };
        }        
    }
}
