using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaEvents.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaEvents.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventsListPage : ContentPage
	{
		public EventsListPage ()
		{
			InitializeComponent ();

            BindingContext = new EventsListViewModel(false);

        }

        private async void GridButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewEventPage()));            
        }


    }
}