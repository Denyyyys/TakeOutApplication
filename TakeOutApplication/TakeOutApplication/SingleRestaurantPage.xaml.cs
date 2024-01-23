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
	public partial class SingleRestaurantPage : ContentPage
	{
		Restaurant selectedRestaurant;

		public SingleRestaurantPage(Restaurant restaurant)
		{
			InitializeComponent();
			this.selectedRestaurant = restaurant;
			var dishes = new List<Dish>
			{
				new Dish{dish_id=1, category="Salad", dish_name="Cezar", price=1.92f, restaurant=restaurant},
				new Dish{dish_id=2, category="Salad", dish_name="Summer Salad", price=2.92f, restaurant=restaurant},
				new Dish{dish_id=3, category="Drinks", dish_name="Coca-Cola", price=1.1f, restaurant=restaurant},
			};

			//dd.Text = restaurant.restaurant_name;
			this.dishesListView.ItemsSource = dishes;
			restaurantNameLabel.Text = restaurant.restaurant_name;
		}

		private void dishesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			if (sender is Image tappedImage)
			{
				if (tappedImage.BindingContext is Dish selectedDish)
				{
					UserData.orderedDishes.Add(selectedDish);
				}
			}
		}
	}
}