using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaEvents.Models;
using XamaEvents.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaEvents.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventsPastPage : ContentPage
	{
		public EventsPastPage ()
		{
			InitializeComponent ();
            BindingContext = new EventsListViewModel(true);
		}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Event item)
            {
                //await(App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync($"app:///xamaevents/detailEvent?id={item.Id}", true);
                await Navigation.PushAsync(new DetailEventPage(new DetailEventViewModel(item)));
                
                ItemsListView.SelectedItem = null;
            }
        }
    }
}