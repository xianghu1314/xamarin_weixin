using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using linli.Models;

namespace linli.Services
{
    public class MockDataStore : IDataStore<User>
    {
        readonly List<User> items;

        public MockDataStore()
        {
            items = new List<User>()
            {
                new User { Id = Guid.NewGuid().ToString(), Name = "x小山花",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png",CreateTime=DateTime.Now },
                new User { Id = Guid.NewGuid().ToString(), Name = "X刷个微博",Sex="male", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/15.png",CreateTime=DateTime.Now },
                new User { Id = Guid.NewGuid().ToString(), Name = "陇原",Sex="male", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png",CreateTime=DateTime.Now },
                new User { Id = Guid.NewGuid().ToString(), Name = "无敌小钢炮",Sex="male", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/17.png",CreateTime=DateTime.Now },
                new User { Id = Guid.NewGuid().ToString(), Name = "马田飞远",Sex="male", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/18.png",CreateTime=DateTime.Now },
                new User { Id = Guid.NewGuid().ToString(), Name = "雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/19.png",CreateTime=DateTime.Now },
                new User { Id = Guid.NewGuid().ToString(), Name = "，雪山飞狐",Sex="female", HeadImgUrl="https://img.xiaopiu.com/static/fashion_app_ui_kit/20.png",CreateTime=DateTime.Now }
            };
        }

        public async Task<bool> AddItemAsync(User item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(User item)
        {
            var oldItem = items.Where((User arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((User arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<User> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<User>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}