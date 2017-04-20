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
    public partial class ListsPage : ContentPage
    {
        public ObservableCollection<ListsViewModel> lists { get; set; }
        private GlobalData _gd;

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
			ObservableCollection<ListsViewModel> lists = new ObservableCollection<ListsViewModel>();

			lists.Add(new ListsViewModel { Name = "Grocery", On = false, ID = lists.Count });
			lists.Add(new ListsViewModel { Name = "Shared Items", On = false, ID = lists.Count });
			lists.Add(new ListsViewModel { Name = "Chores", On = true, ID = lists.Count });
			lists.Add(new ListsViewModel { Name = "Repairs", On = true, ID = lists.Count });
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



       async void OnTap(object sender, ItemTappedEventArgs e)
        {
            int index = ((ListsViewModel)e.Item).ID;
            await Navigation.PushAsync(new groupProject01.ListItemPage(index, _gd));
            //DisplayAlert("Item Tapped", ((ListsViewModel)e.Item).ID.ToString(), "Ok");
        }

        public void onListTypeClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void onHideListClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
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
