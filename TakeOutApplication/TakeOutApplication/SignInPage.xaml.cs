using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeOutApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }


        private async void Button_Sign_In_Clicked(object sender, EventArgs e)
        {
            UserData.Name = "Denys";
            await Shell.Current.GoToAsync($"//ProfilePage");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        //private async void loginButton_Clicked(object sender, EventArgs e)
        //{
        //    bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
        //    bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
        //    if (!isEmailEmpty && !isPasswordEmpty)
        //    {
        //        //Navigation.PushAsync(new MainPage());
        //        await Shell.Current.GoToAsync("//main");
        //    }
        //    else
        //    {
        //        // TODO: show komunikat
        //    }
        //}
    }
}