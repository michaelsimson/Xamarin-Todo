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
	public partial class AddCustomer : ContentPage
	{
		public AddCustomer ()
		{
			InitializeComponent ();
		}

        private void BtnSave_Clicked(object sender, EventArgs e)
        {

        }
    }
}