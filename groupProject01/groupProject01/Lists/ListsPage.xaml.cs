using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
    public partial class ListsPage : ContentPage                        //ListsPage class
    {
        public ObservableCollection<ListsViewModel> lists { get; set; } //initializes a collection that notifies when items are added, removed, or refreshed
        private GlobalData _gd;                                         //instantiates global variable GlobalData to store the global data

        public ListsPage(GlobalData gd)                                 //ListsPage constructor
        {
            InitializeComponent();                                      //initializes UI objects with values provided, initializes elements
            _gd = gd;                                                   //sets private instance of global data
            lists =  _gd.ListsDataInstance.lists;                       //gets the lists data from data file
            lstView.ItemsSource = lists;                                //sets the source of items to template and display
        }



        /// <summary>
        /// Fires when switch is turned on or off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SwitchToggled(object sender, EventArgs e) 
        {
            int index = ((CustomSwitch)sender).ID;  //gets the ID of the cell that is toggled (sender=switch)
            if (index != -1)                        //when user toggles switch
            {
                //index is -1 when loading, false toggle event
                DisplayAlert("Switch","Switch","Ok");       //TESTING
                // Do stuff
            }
        }



       /// <summary>
       /// Listener that fires when a list is tapped
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       async void OnTap(object sender, ItemTappedEventArgs e)
        {
            int index = ((ListsViewModel)e.Item).ID;    //gets the ID of the list item (sender=row)
            await Navigation.PushAsync(new groupProject01.ListItemPage(index, _gd)); //viewing the list item page even while other things occur
            //DisplayAlert("Item Tapped", ((ListsViewModel)e.Item).ID.ToString(), "Ok"); TESTING
        }

        public void onDeleteListClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void onAddListClicked(object Sender, EventArgs e)
        {
            //TODO pass in type of list- private vs public?

            throw new NotImplementedException();
        }
    }
}
