using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeOutApplication.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeOutApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
		public ObservableCollection<HistoryOrder> activeOrders = new ObservableCollection<HistoryOrder> { };
		public ObservableCollection<HistoryOrder> finishedOrders = new ObservableCollection<HistoryOrder> { };
		public ObservableCollection<HistoryOrder> dish_names = new ObservableCollection<HistoryOrder>();

		public HistoryPage()
        {
            InitializeComponent();
			foreach (var order in UserData.orders)
			{
				var new_dish = new HistoryOrder() { dish_names = string.Join(", ", order.Dishes.Select(dish => dish.dish_name)), date = order.date.ToString("dd, MMM yyyy"), Id = order.Id, status = UtilityFunctions.ConvertStatusCodeToString(order.status), total_sum = order.total_sum };
				dish_names.Add(new_dish);
                if (order.status >= 0 && order.status <= 3)
				{
					activeOrders.Add(new_dish);
				}
				else if (order.status == 4)
				{
					finishedOrders.Add(new_dish);
				}
			}


			// Assign the collections to the corresponding views


			//finishedOrdersView.ItemsSource = finishedOrders;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			dish_names = new ObservableCollection<HistoryOrder>() { };
			foreach (var order in UserData.orders)
			{
				var new_dish = new HistoryOrder() { dish_names = string.Join(", ", order.Dishes.Select(dish => dish.dish_name)), date = order.date.ToString("dd, MMM yyyy"), Id = order.Id, status = UtilityFunctions.ConvertStatusCodeToString(order.status), total_sum = order.total_sum };
				dish_names.Add(new_dish);
				if (order.status >= 0 && order.status <= 3)
				{
					activeOrders.Add(new_dish);
				}
				else if (order.status == 4)
				{
					finishedOrders.Add(new_dish);
				}
			}

			activeOrdersView.ItemsSource = activeOrders;
			finishedOrdersView.ItemsSource = finishedOrders;
			ForceLayout();
		}
	}
}