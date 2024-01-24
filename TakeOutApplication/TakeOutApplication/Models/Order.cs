using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TakeOutApplication.Models
{
    public class Order
    {
        public ObservableCollection<Dish> Dishes {  get; set; } = new ObservableCollection<Dish>();
        public float total_sum { get; set; }
        
		public int time_to_deliver { get; set; }

		public int Id { get; set; } = 3;
		
		public int restaurantId { get; set; }

		public int userId { get; set; }

		public DateTime date { get; set; }

		public float latitude { get; set; }
		
		public float longitude { get; set; }

		public int status { get; set; }
	}
}
