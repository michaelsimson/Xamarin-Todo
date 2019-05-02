using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RootPage : ContentPage
	{
		public RootPage ()
		{
			InitializeComponent ();
		}

        private void OnLogoutButtonClicked(object sender, EventArgs e)
        {
          Navigation.PushAsync(new  MainPage());
        }

        private void gotoMaintainnance(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        private void gotoCustomer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomerPage());
        }
    }
}