using System;
using System.Collections.Generic;
using linli.Models;
using Xamarin.Forms;

namespace linli.CustemViews
{
    public class NativeListView : ListView
    {
        public static readonly BindableProperty MessagesProperty =
          BindableProperty.Create("Messages", typeof(IEnumerable<Message>), typeof(NativeListView), new List<Message>(),defaultBindingMode:BindingMode.TwoWay);

        public IEnumerable<Message> Messages
        {
            get { return (IEnumerable<Message>)GetValue(MessagesProperty); }
            set { SetValue(MessagesProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }
}
