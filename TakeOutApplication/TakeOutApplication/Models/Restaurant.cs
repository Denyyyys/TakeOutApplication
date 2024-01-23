using System;
using System.Collections.Generic;
using System.Text;

namespace TakeOutApplication.Models
{
    public class Restaurant
    {
		public int restaurant_id { get; set; }
		public string restaurant_name { get; set; }
		public double longitude { get; set; }
		public double latitude { get; set; }
	}
}
