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
					bool result = await DisplayAlert("Question", $"Are you sure you want to delete {selectedDish.dish_name} from cart?", "YES", "No");

					if (result)
					{
						UserData.orderedDishes.Remove(selectedDish);
						//MessagingCenter.Send<object>(this, "RefreshUI");
						//Device.BeginInvokeOnMainThread(() =>
						//{
						//	// Update UI elements here
						//});
					}
					
				}
			}
		}
	}
}