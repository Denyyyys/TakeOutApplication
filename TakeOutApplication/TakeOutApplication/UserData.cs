using System;
using System.Collections.Generic;
using System.Text;
using TakeOutApplication.Models;

namespace TakeOutApplication
{
    public static class UserData
    {
        private static string _name = "nameeee";
        public static string Name { get { return _name; } set { _name = value; } }
        public static string Password { get; set; }
        public static float Balance { get; set; }

		public static List<Dish> orderedDishes { get; set; } = new List<Dish>() {
			new Dish{dish_id=1, category="Salad", dish_name="Cezar", price=1.92f, restaurant=new Restaurant(){restaurant_name="Laticu"} },
			new Dish{dish_id=2, category="Drink", dish_name="Coca-Cola", price=2.92f, restaurant=new Restaurant(){restaurant_name="Laticu"} },
		};

	}
}
