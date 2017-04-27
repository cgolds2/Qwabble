using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupProject01;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace groupProject01
{
	
	public partial class AddItemPage : ContentPage
	{
        GlobalData _gd;
        int type = 0;
		public AddItemPage (GlobalData gd, int ListType)
		{
            NavigationPage.SetHasNavigationBar(this, false);                                        //hides the default naviagion bar
            type = ListType;
            gd = _gd;
			InitializeComponent ();
		}
        
        async void OnAddItem(object sender, EventArgs e)
        {
            ListItemObject it = new ListItemObject();
            it.noteName = itemNameTextField.Text;
            it.data = itemDetailTextField.Text; 

            it.data = itemDetailTextField.Text;
            await(ServerHandeler.sendList(it, _gd));
            Application.Current.MainPage = new NavigationPage(new groupProject01.ListsPage(_gd));            //if lists button is pressed


        }
        async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            // await Navigation.PushAsync(new groupProject01.ListsPage(_gd));
        }
    }
}
