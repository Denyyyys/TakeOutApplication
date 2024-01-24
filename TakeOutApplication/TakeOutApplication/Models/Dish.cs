using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TakeOutApplication.Models
{
    public class Dish : INotifyPropertyChanged
	{
        public int dish_id { get; set; }
        public string dish_name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public Restaurant restaurant { get; set; }
        public string category { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
