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
	public partial class DetailEventPage : ContentPage
	{
        DetailEventViewModel _viewModel;

        public DetailEventPage ()
		{
			InitializeComponent ();

            _viewModel = new DetailEventViewModel(new Models.Event());
            BindingContext = _viewModel;
        }

        public DetailEventPage(DetailEventViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            BindingContext = _viewModel;
        }
    }
}