using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using linli.Models;

namespace linli.Services
{
    public class MessageDataStore : IDataStore<Message>
    {
        public Task<bool> AddItemAsync(Message item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<Message> GetItems()
        {
            var list = new List<Message>();
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "在吗？",
                CreateTime = DateTime.Now,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "不再",
                CreateTime = DateTime.Now,
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "晚安^_^!",
                CreateTime = DateTime.Now,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Image,
                Content = "http://pic1.win4000.com/pic/0/e6/f119621393.jpg",
                CreateTime = DateTime.Now,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            
            return list;
        }

        public async Task<IEnumerable<Message>> GetItemsAsync(bool forceRefresh = false)
        {
            var list = new List<Message>();
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "在吗？",
                CreateTime = DateTime.Now,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "不再",
                IsMySelf = true,
                CreateTime = DateTime.Now,
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "晚安^_^!",
                CreateTime = DateTime.Now,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Text,
                Content = "晚安，么么哒^_^!",
                CreateTime = DateTime.Now,
                IsMySelf=true,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Image,
                Content = "http://pic1.win4000.com/pic/0/e6/f119621393.jpg",
                CreateTime = DateTime.Now,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            list.Add(new Message
            {
                MessageType = MessageType.Image,
                Content = "http://pic1.win4000.com/pic/0/e6/f119621393.jpg",
                CreateTime = DateTime.Now,
                IsMySelf=true,
                FromUser = new User { Id = Guid.NewGuid().ToString(), Name = "x小山花", Sex = "female", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/14.png", CreateTime = DateTime.Now },
                ToUser = new User { Id = Guid.NewGuid().ToString(), Name = "陇原", Sex = "male", HeadImgUrl = "https://img.xiaopiu.com/static/fashion_app_ui_kit/16.png", CreateTime = DateTime.Now },
                Id = Guid.NewGuid().ToString()
            });
            return await Task.FromResult(list);
        }

        public Task<bool> UpdateItemAsync(Message item)
        {
            throw new NotImplementedException();
        }
    }
}
