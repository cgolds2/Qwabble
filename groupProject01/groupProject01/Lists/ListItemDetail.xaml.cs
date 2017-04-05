using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01.Lists
{
	public partial class ListItemDetail : ContentPage
	{
		public ListItemDetail (int ListID, GlobalData gd)
		{
			InitializeComponent ();
            lblLabel.Text = ListID.ToString();

        }
	}
}
