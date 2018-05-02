using BigGreenButton.Dependencies;
using BigGreenButton.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BigGreenButton
{
	public partial class MainPage : ContentPage
	{
        private GreenButtonViewModel _viewModel;

		public MainPage()
		{
			InitializeComponent();
            BindingContext = _viewModel = new GreenButtonViewModel();
		}
	}
}
