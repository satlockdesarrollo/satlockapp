﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatlockApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SatlockApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            var mainViewModel = MainViewModel.GetInstance();
            userText.Text = mainViewModel.User;
        }
	}
}