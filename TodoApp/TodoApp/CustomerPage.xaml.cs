using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using TodoApp.Modal;

namespace TodoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomerPage : ContentPage
	{
		public CustomerPage ()
		{
			InitializeComponent ();
            getRequests();

        }

        private async void getRequests()
        {
            HttpClient client = new HttpClient();
            try
            {

                var response = await client.GetStringAsync("http://172.25.0.227:8081/api/getCustomerGridData");
                var maintananceRequest = JsonConvert.DeserializeObject<List<Customer>>(response);
                CustomerListView.ItemsSource = maintananceRequest;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCustomer());
        }
    }

}