using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using linli.Models;
using linli.Services;
using Xamarin.Forms;

namespace linli.ViewModels
{
    public class MessageViewModel: BaseViewModel<Message>
    {
        public ObservableCollection<Message> Messages { get; set; }
        public Command LoadItemsCommand { get; set; }
        public MessageViewModel(User user = null)
        {
            Title = user?.Name;
            Messages = new ObservableCollection<Message>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Messages.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Messages.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
