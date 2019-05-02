using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
           
        }
       

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(TxtEmail.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(TxtPassword.Text);
            if(isEmailEmpty || isPasswordEmpty)
            {
                await DisplayAlert("Alert!", "Email/Password mandatory.", "Close");
            }
            else
            {
                Navigation.InsertPageBefore(new RootPage(), this);
                await Navigation.PopAsync();
            }
        }
    }
}
