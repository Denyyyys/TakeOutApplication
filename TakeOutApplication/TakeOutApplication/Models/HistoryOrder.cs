using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TakeOutApplication.Models
{
	public class HistoryOrder
	{
		public float total_sum { get; set; }
		public string dish_names { get; set; }
		public int Id { get; set; } = 3;
		public string date { get; set; }
		public string status { get; set; }
	}
}
