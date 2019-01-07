using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaEvents.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamaEvents
{
    public partial class TheShell : Shell
    {
        public ICommand GoToSettingsCommand => new Command(GoToSettings);
        public ICommand GoToAboutUsCommand => new Command(GoToAboutUs);

        private void GoToAboutUs(object obj)
        {
            (App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync("app:///xamaevents/tab/test/about", true);
            (App.Current.MainPage as Xamarin.Forms.Shell).FlyoutIsPresented = false;
        }

        public ICommand GoToPrivacyPolicyCommand => new Command(GoToPrivacyPolicy);
        
        public TheShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("settings", typeof(SettingsPage));
            
        }

        private void GoToSettings(object obj)
        {
            (App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync("app:///xamaevents/tab/test/settings?payload=4.0", true);
            (App.Current.MainPage as Xamarin.Forms.Shell).FlyoutIsPresented = false;
        }

        private async void GoToPrivacyPolicy(object obj)
        {
            await Browser.OpenAsync("https://www.riojadotnet.com", BrowserLaunchMode.SystemPreferred);
        }
    }
}
