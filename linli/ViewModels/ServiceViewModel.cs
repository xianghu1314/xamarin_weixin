using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Android.Provider;
using linli.Models;
using Xamarin.Forms;

namespace linli.ViewModels
{
    public class ServiceViewModel: BaseViewModel<string>
    {
        public ObservableCollection<string> Xialas { get; set; }
        public ObservableCollection<List<Models.Menu>> Menus { get; set; }
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
            Menus = new ObservableCollection<List<Models.Menu>>
            {
                new List<Models.Menu>
                {
                    new Models.Menu{
                        Image="https://ss2.bdstatic.com/70cFvnSh_Q1YnxGkpoWK1HF6hhy/it/u=2790351072,414060128&fm=26&gp=0.jpg",
                        Title="水果"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    },
                },
                new List<Models.Menu>
                {
                    new Models.Menu{
                        Image="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1583832841150&di=0ece782408832469004f4df434e9f4e4&imgtype=0&src=http%3A%2F%2Fbpic.588ku.com%2Felement_water_img%2F18%2F06%2F12%2Fa003ffdf69c03edd327fcd5007105ec3.jpg",
                        Title="水果"
                    },
                    new Models.Menu{
                        Image="https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=123751265,3939759067&fm=26&gp=0.jpg",
                        Title="蔬菜"
                    }
                }
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
