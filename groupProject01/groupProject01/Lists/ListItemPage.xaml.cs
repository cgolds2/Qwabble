using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{

    public partial class ListItemPage : ContentPage                                                 //class that controls the list items
	{
        public List<ListItemObject> items { get; set; }                                             //creates a list of list item objects
        private GlobalData _gd;                                                                     //instantiates global variable GlobalData to store the global data

        public ListItemPage (int ListID, GlobalData gd)                                             //ListItemPage constructor
		{
            NavigationPage.SetHasNavigationBar(this, false);                                        //hides the default naviagion bar
            InitializeComponent();                                                                  //initializes UI objects
            _gd = gd;                                                                               //sets private instance of global data
            _gd.ListsDataInstance.getItemsInList(_gd, ListID);                                      //populates the instance with the items in the list that was clicked on previously
            items = _gd.ListsDataInstance.items;                                                    //gets the item data from the data file
            lstView.ItemsSource = items;                                                            //sets the source of items to display
        }

       async void OnTap(object sender, ItemTappedEventArgs e)                                       //method for when an item in the current page is tapped
        {

            int index = ((ListItemObject)e.Item).ListID;                                            //finds the index of the item tapped
            var item = items[index];                                                                //items.get(index), gets the item at that specified index
            if (item.listType==0)                                                                      //if the item has additional info
            {
                await Navigation.PushAsync(new groupProject01.Lists.ListItemDetail(item, _gd),false);     //directs to the page to view the details of the item
            }
        }

        void SwitchToggled(object sender, EventArgs e)
        {
            /*int index = ((ListItemObject)e.Item).ListID;                                            //finds the index of the item tapped
            var item = items[index];                                                                //items.get(index), gets the item at that specified index
            item.On = !item.On;                                                                     //swaps the value fo that item's toggle*/
        }   
	}
  
}
