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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            getRequests();

        }
        private async void getRequests()
        {
            HttpClient client = new HttpClient();
            try
            {

                var response = await client.GetStringAsync("http://172.25.0.227:8081/api/getMaintainanceGridData");
                var maintananceRequest = JsonConvert.DeserializeObject<List<CustomerMaintanance>>(response);
                MaintananceListView.ItemsSource = maintananceRequest;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddMaintanance());
        }
    }
}