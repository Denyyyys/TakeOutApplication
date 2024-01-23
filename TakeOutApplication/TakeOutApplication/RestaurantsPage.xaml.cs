using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeOutApplication.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeOutApplication
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantsPage : ContentPage
    {
        public RestaurantsPage()
        {
            InitializeComponent();

        }

		protected override void OnAppearing()
		{
			base.OnAppearing();

            var restaurants = new List<Restaurant> 
            {
                new Restaurant{restaurant_id=1, latitude=52.084905, longitude=19.764155,restaurant_name="Manekin" },
                new Restaurant{restaurant_id=2, latitude=52.311166, longitude=12.847231,restaurant_name="Facil" },
                new Restaurant{restaurant_id=3, latitude=52.484905, longitude=10.764155,restaurant_name="BLESS" },
                new Restaurant{restaurant_id=4, latitude=56.484905, longitude=9.764155,restaurant_name="Maximilians" },
			};
            restaurantListView.ItemsSource = restaurants;
        }

		private void restaurantListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var selectedRestaurant = restaurantListView.SelectedItem as Restaurant;
			if (selectedRestaurant != null)
			{
                Navigation.PushAsync(new SingleRestaurantPage(selectedRestaurant));
            }

		}
	}
}