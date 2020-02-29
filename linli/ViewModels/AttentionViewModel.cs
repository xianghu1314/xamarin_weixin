using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using linli.Models;
using linli.Utils;
using linli.Services;
using Xamarin.Forms;

namespace linli.ViewModels
{
    public class AttentionList: ObservableCollection<User>
    {
        public string GroupTitle { get; set; }
        public string ShortName { get; set; }
    }
    public class AttentionViewModel: BaseViewModel<User>
    {
        public ObservableCollection<AttentionList> Attentions { get; set; }
        public Command LoadItemsCommand { get; set; }
        public AttentionViewModel()
        {
            Attentions = new ObservableCollection<AttentionList>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadAttentionsCommand());
            Title = "关注";
        }
        public async Task ExecuteLoadAttentionsCommand() {
            var items = await new MockDataStore().GetItemsAsync();
            var g = from i in items
                    group i by SpellUtils.GetFirstPinyin(i.Name[0], "★").ToUpper();
            foreach (var item in g)
            {
                var at = new AttentionList
                {
                    GroupTitle = item.Key,
                    ShortName = item.Key
                };
                foreach (var item2 in item.ToList<User>())
                {
                    at.Add(item2);
                }
                Attentions.Add(at);
            }
        }
    }
}
