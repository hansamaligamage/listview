using OrderPizza.Data;
using OrderPizza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace OrderPizza
{
	public partial class App : Application
	{

        public static PizzaManager PizzaManager { get; private set; }

        public App ()
		{
			InitializeComponent();
            PizzaManager = new PizzaManager(new PizzaService());
			MainPage = new OrderPizza.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
