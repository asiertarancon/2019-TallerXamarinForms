using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaEvents.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaEvents.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewEventPage : ContentPage
	{
        public Event Event { get; set; } = new Event()
        {
            DateStart = DateTime.Today,
            DateEnd = DateTime.Today
        };

        public NewEventPage ()
		{
			InitializeComponent ();

            BindingContext = this;
        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Instance.Send<Event>(Event, "AddEvent");
            await Navigation.PopModalAsync();
        }
    }
}