using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{

    public partial class ListItemPage : ContentPage
	{
        public ObservableCollection<ListItemObject> items { get; set; }
        private GlobalData _gd;

        public ListItemPage (int ListID, GlobalData gd)
		{
                        NavigationPage.SetHasNavigationBar(this, false); InitializeComponent();
            _gd = gd;
            _gd.ListsDataInstance.getItemsInList(ListID);
            items = _gd.ListsDataInstance.items;
            lstView.ItemsSource = items;
        }

       async void OnTap(object sender, ItemTappedEventArgs e)
        {

            int index = ((ListItemObject)e.Item).ListID;

            var item = items[index]; //items.get(index)
            await Navigation.PushAsync(new groupProject01.Lists.ListItemDetail(item, _gd));
        }
    void SwitchToggled(object sender, EventArgs e)
    {

     
    }   
	}
  
}
