using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TakeOutApplication.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace TakeOutApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
	{
		public bool _showYouHaveOrders = true;
		public bool _showNoOrdersView = false;
		public bool showNoOrdersView { get; set; }
		public bool showYouHaveOrders { get; set; }
		//public ObservableCollection<Order> Orders { get; set; }
		public ObservableCollection<Order> Orders { get; set; } = UserData.orders;
		public ProfilePage()
        {
			BindingContext = this; // Ensure that BindingContext is set to the instance of ProfilePage

			InitializeComponent();
           
            string email = "user@gmail.com";
            float balance = UserData.Balance;
            string favouriteRestaurant = "Central";
            string favouriteFood = "Almas caviar";
            emailLabel.Text = email;
            balanceLabel.Text = $"${balance}";
            favouriteRestaurantLabel.Text = favouriteRestaurant;
            favouriteFoodLabel.Text = favouriteFood;
			//ordersListView.ItemsSource = UserData.orders;
			//Orders = UserData.orders;
			//OrdersListView.ItemsSource = UserData.orders;


		}
		protected override void OnAppearing()
        {
            base.OnAppearing();
			string email = "user@gmail.com";
			float balance = UserData.Balance;
			string favouriteRestaurant = "Central";
			string favouriteFood = "Almas caviar";
			emailLabel.Text = email;
			balanceLabel.Text = $"${balance}";
			favouriteRestaurantLabel.Text = favouriteRestaurant;
			favouriteFoodLabel.Text = favouriteFood;
			//ordersListView.ItemsSource = UserData.orders;
			//Orders = UserData.orders;
			if (UserData.orders.Count > 0)
			{
				showNoOrdersView = false;
				showYouHaveOrders = true;
				OnPropertyChanged(nameof(showNoOrdersView));
				OnPropertyChanged(nameof(showYouHaveOrders));
			}
			else
			{
				showNoOrdersView = true;
				showYouHaveOrders = false;
				OnPropertyChanged(nameof(showNoOrdersView));
				OnPropertyChanged(nameof(showYouHaveOrders));
			}
			ForceLayout();
		}

		private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignInPage"); 
        }

		private async void ShowOrdersLabelTapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//HistoryPage");
		}

		//public new event PropertyChangedEventHandler PropertyChanged;
		//protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
		//{
		//	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		//}

	}
}