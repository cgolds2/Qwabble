using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //starts up the app by calling the globaldata constructor
            GlobalData gd = new GlobalData();

			//MainPage = new groupProject01.MainPage();
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
