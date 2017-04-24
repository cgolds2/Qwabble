using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace groupProject01
{
	
	public partial class AddItemPage : ContentPage
	{
        GlobalData _gd;
		public AddItemPage (GlobalData gd)
		{
            gd = _gd;
			InitializeComponent ();
		}
        
        async void OnAddItem(object sender, EventArgs e)
        {
            ListItemObject it = new ListItemObject();
            it.noteName = itemNameTextField.Text;
            //set it.ListID
            if (itemDetailTextField.Text.Equals(""))
            {
                it.listType = 0;
            }
            else
            {
                it.listType = 1;
            }
            it.data = itemDetailTextField.Text;
            ServerHandeler.sendList(it, _gd);
            await Navigation.PushAsync(new groupProject01.ListsPage(_gd));
        }
    }
}
