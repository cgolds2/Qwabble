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
        public ObservableCollection<ListOfListsObject> lists { get; set; } //initializes a collection that notifies when items are added, removed, or refreshed
        private GlobalData _gd;                                         //instantiates global variable GlobalData to store the global data


        #region BottomBarStuff

        public void OnHome(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnList(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnCalendar(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnMessaging(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnSetting(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public ListsPage()
		{

			InitializeComponent();
			//_gd = gd;
			ObservableCollection<ListOfListsObject> lists = new ObservableCollection<ListOfListsObject>();

			lists.Add(new ListOfListsObject { Name = "Grocery" });
			lists.Add(new ListOfListsObject { Name = "Shared Items" });
			lists.Add(new ListOfListsObject { Name = "Chores"});
			lists.Add(new ListOfListsObject { Name = "Repairs" });
			//lists = _gd.ListsDataInstance.lists;
			lstView.ItemsSource = lists;


		}
        //public ListsPage(GlobalData gd)
        //{

        //    InitializeComponent();
        //    _gd = gd;
        //   lists =  _gd.ListsDataInstance.lists;
        //    lstView.ItemsSource = lists;
            

        //}



        void SwitchToggled(object sender, EventArgs e)
        {
            
            int index = ((CustomSwitch)sender).ID;
            //((CustomSwitch)sender).IsVisible = false;
            if (index != -1)
            {
                //index is -1 when loading, false toggle event
                DisplayAlert("Switch","Switch","Ok");
                // Do stuff

            }
        }




       async void OnTap(object sender, ItemTappedEventArgs e)                       //Listener that fires when a list is tapped
        {
            int index = ((ListOfListsObject)e.Item).ID;                                    //gets the ID of the list item (sender=row)
            await Navigation.PushAsync(new groupProject01.ListItemPage(index, _gd)); //viewing the list item page even while other things occur
            //DisplayAlert("Item Tapped", ((ListsObject)e.Item).ID.ToString(), "Ok"); TESTING
        }

        public void onDeleteListClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
