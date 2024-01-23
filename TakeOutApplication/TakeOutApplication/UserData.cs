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

		public static List<Dish> orderedDishes { get; set; } = new List<Dish>();

	}
}
