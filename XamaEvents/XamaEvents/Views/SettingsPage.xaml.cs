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
    public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
            BindingContext = new SettingsViewModel();
		}
    }
}