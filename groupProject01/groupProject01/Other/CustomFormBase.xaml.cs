using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01.Other
{
	public partial class CustomFormBase : ContentPage
	{
		public CustomFormBase ()
		{
			            NavigationPage.SetHasNavigationBar(this, false); InitializeComponent();
		}

	}
}
