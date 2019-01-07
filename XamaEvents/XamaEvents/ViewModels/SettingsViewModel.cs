using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamaEvents.ViewModels
{
    [QueryProperty("Payload", "payload")]
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
            Version = AppInfo.VersionString;
            PrivacyCommand = new Command(async () =>
            {
                await Browser.OpenAsync("https://www.riojadotnet.com", BrowserLaunchMode.SystemPreferred);
            });
        }

        public Command PrivacyCommand { get; set; }

        private string _payload;
        public string Payload
        {
            get => _payload;
            set => SetAndRaisePropertyChanged(ref _payload, value);
        }

        private string _version;
        public string Version
        {
            get => _version;
            set => SetAndRaisePropertyChanged(ref _version, value);
        }
    }
}
