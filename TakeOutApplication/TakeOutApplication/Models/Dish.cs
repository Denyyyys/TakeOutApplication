using System;
using System.Collections.Generic;
using System.Text;

namespace TakeOutApplication.Models
{
    public class Dish
    {
        public int dish_id { get; set; }
        public string dish_name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public Restaurant restaurant { get; set; }
        public string category { get; set; }
    }
}
