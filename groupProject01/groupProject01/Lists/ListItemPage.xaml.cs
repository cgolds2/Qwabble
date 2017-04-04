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
        public ObservableCollection<ListsViewModel> items { get; set; }
        private GlobalData _gd;

        public ListItemPage (int ListID, GlobalData gd)
		{
            InitializeComponent ();
            _gd = gd;
            _gd.ListsDataInstance.getItemsInList(ListID);
            items = _gd.ListsDataInstance.items;
            lstView.ItemsSource = items;
        }

       async void OnTap(object sender, ItemTappedEventArgs e)
    {
       
        //DisplayAlert("Item Tapped", ((ListsViewModel)e.Item).ID.ToString(), "Ok");
    }
    void SwitchToggled(object sender, EventArgs e)
    {

     
    }   
	}
  
}
