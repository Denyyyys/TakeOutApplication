using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TakeOutApplication.Models;
using Xamarin.Forms;

namespace TakeOutApplication
{
    class MyCartPageViewModel: BindableObject
    {
		private ObservableCollection<Dish> _dishes;

		public ObservableCollection<Dish> Dishes
		{
			get { return _dishes; }
			set
			{
				_dishes = value;
				OnPropertyChanged();
			}
		}

		public ICommand DeleteCommand { get; }

        public MyCartPageViewModel()
        {
			Dishes = new ObservableCollection<Dish>()
			{

			};
        }
    }
}
