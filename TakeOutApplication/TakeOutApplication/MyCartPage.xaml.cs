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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCartPage : ContentPage
    {
        public MyCartPage()
        {
            InitializeComponent();
			cartListView.ItemsSource = UserData.orderedDishes;
			float sum = UserData.orderedDishes.Sum(item => item.price);
			totalPriceLabel.Text = $"Total Price: {sum}$";
			//BindingContext = new MyCartPageViewModel();

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			float sum = UserData.orderedDishes.Sum(item => item.price);
			totalPriceLabel.Text = $"Total Price: {sum}$";
		}

		//private void cartListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		//{
		//if (sender is Image tappedImage)
		//{
		//	if (tappedImage.BindingContext is Dish selectedDish)
		//	{

		//	}
		//}
		//}


		private async void removeItem_Tapped(object sender, EventArgs e)
		{
			if (sender is Image tappedImage)
			{
				if (tappedImage.BindingContext is Dish selectedDish)
				{
					bool result = await DisplayAlert("Pytanie", $"Are you sure you want to delete {selectedDish.dish_name} from cart?", "YES", "No");

					if (result)
					{
						UserData.orderedDishes.Remove(selectedDish);
						float sum = UserData.orderedDishes.Sum(item => item.price);
						totalPriceLabel.Text = $"Total Price: {sum}$";
						//MessagingCenter.Send<object>(this, "RefreshUI");
						//Device.BeginInvokeOnMainThread(() =>
						//{
						//	// Update UI elements here
						//});
					}
					
				}
			}
		}

		private async void OrderButton_Clicked(object sender, EventArgs e)
		{
			if(UserData.orderedDishes.Sum(item => item.price) == 0)
			{
				await DisplayAlert("Ooopsie :(", $"Nie wybrałeś żadnych produktów", "OK");
			}
			else if (UserData.Balance < UserData.orderedDishes.Sum(item => item.price))
			{
				await DisplayAlert("Ooopsie :(", $"Nie posiadasz wystarczająco środków na koncie w celu złożenia zamówienia. Masz: {UserData.Balance}$. Potrzebujesz {UserData.orderedDishes.Sum(item => item.price)}$", "OK");
			}
			else
			{
				UserData.Balance -= UserData.orderedDishes.Sum(item => item.price);
				await DisplayAlert("Powodzenie!", $"Zamówienie zostało złożone, możesz zobaczyć go w swoich zamówieniach", "OK");
				UserData.orders.Add(new Order() { date = DateTime.Now, Id = 0, total_sum= UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0});
				UserData.orderedDishes.Clear();
				totalPriceLabel.Text = $"Total Price: {0}$";
			}
		}
	}
}