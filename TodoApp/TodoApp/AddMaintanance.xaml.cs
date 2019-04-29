using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoApp.Modal;
using Newtonsoft.Json;
using System.Net.Http;

namespace TodoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddMaintanance : ContentPage
	{
		public AddMaintanance ()
		{
			InitializeComponent ();
		}

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            CustomerMaintanance cusMaintanance = new CustomerMaintanance()
            {
                Title = TxtTitle.Text,
                Subject = TxtSubject.Text,
                Description = TxtDescription.Text
            };
            var json = JsonConvert.SerializeObject(cusMaintanance);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            var result = await client.PostAsync("http://172.25.0.227:8081/api/saveMaintainance",content);
           await Navigation.PushAsync(new HomePage());
        }
    }
}