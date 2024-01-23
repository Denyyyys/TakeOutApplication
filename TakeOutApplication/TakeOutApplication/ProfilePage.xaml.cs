using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeOutApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
           
            string email = "user@gmail.com";
            float balance = 100.2f;
            string favouriteRestaurant = "Central";
            string favouriteFood = "Almas caviar";
            emailLabel.Text = email;
            balanceLabel.Text = $"${balance}";
            favouriteRestaurantLabel.Text = favouriteRestaurant;
            favouriteFoodLabel.Text = favouriteFood;

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignInPage"); 
        }

    }
}