using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TakeOutApplication.Models;

namespace TakeOutApplication
{
    public static class UserData
    {
        private static string _name = "nameeee";
        public static string Name { get { return _name; } set { _name = value; } }
        public static string Password { get; set; }
		public static float Balance { get; set; } = 3.2f;

		public static ObservableCollection<Dish> orderedDishes { get; set; } = new ObservableCollection<Dish>() {
			new Dish{dish_id=1, category="Salad", dish_name="Cezar", price=1.92f, restaurant=new Restaurant(){restaurant_name="Laticu"} },
			new Dish{dish_id=2, category="Drink", dish_name="Coca-Cola", price=2.92f, restaurant=new Restaurant(){restaurant_name="Laticu"} },

		};

		public static ObservableCollection<Order> orders { get; set; } = new ObservableCollection<Order>()
		{
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 1, total_sum=UserData.orderedDishes.Sum(item => item.price), time_to_deliver=2, status=0, Dishes=orderedDishes},
			//new Order() { date = DateTime.Now, Id = 2, total_sum = UserData.orderedDishes.Sum(item => item.price), time_to_deliver = 3, status = 0, Dishes = orderedDishes},
			//new Order() { date = DateTime.Now, Id = 2, total_sum = UserData.orderedDishes.Sum(item => item.price), time_to_deliver = 3, status = 1, Dishes = orderedDishes},
			//new Order() { date = DateTime.Now, Id = 2, total_sum = UserData.orderedDishes.Sum(item => item.price), time_to_deliver = 3, status = 4, Dishes = orderedDishes}
		};
	};
}
