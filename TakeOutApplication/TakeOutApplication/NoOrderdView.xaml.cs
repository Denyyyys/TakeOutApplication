﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeOutApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NoOrderdView : ContentView
	{
		public NoOrderdView ()
		{
			InitializeComponent ();
		}

		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//RestaurantsPage");
		}
    }
}