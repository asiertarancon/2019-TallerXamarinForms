using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaEvents.Models;
using XamaEvents.Services;
using Xamarin.Forms;

namespace XamaEvents.ViewModels
{
    public class EventsListViewModel : BaseViewModel
    {
        public EventsListViewModel(bool past)
        {
            LoadItemsCommand = new Command(async () => await LoadItems(past));
            MessagingCenter.Subscribe<Event>(this, "AddEvent", async e =>
            {
                await DataStore.AddItemAsync(e);
                Events.Add(e);
            });

            LoadItems(past);
        }

        public IDataStore<Event> DataStore { get; set; } = new MockDataStore();
        public Command LoadItemsCommand { get; set; }
        public ObservableCollection<Event> Events { get; set; } = new ObservableCollection<Event>();
        async Task LoadItems(bool past)
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                Events.Clear();
                var events = await DataStore.GetItemsAsync(true);
                if(past)
                    events = events.Where(e => e.DateStart < DateTime.Now);
                else
                    events = events.Where(e => e.DateStart >= DateTime.Now);

                foreach (var item in events)
                {
                    Events.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
