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
		public ListItemDetail (ListItemObject currentItem, GlobalData gd)
		{
			            NavigationPage.SetHasNavigationBar(this, false); InitializeComponent();

            lblLabel.Text = currentItem.data;

        }
        async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            // await Navigation.PushAsync(new groupProject01.ListsPage(_gd));
        }
    }
}
