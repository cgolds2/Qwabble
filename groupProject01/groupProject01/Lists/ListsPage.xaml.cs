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

       


        public ListsPage(GlobalData gd)
        {

            InitializeComponent();
            _gd = gd;
           lists =  _gd.ListsDataInstance.lists;
            lstView.ItemsSource = lists;

        }



        void SwitchToggled(object sender, EventArgs e)
        {
            
            int index = ((CustomSwitch)sender).ID;
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
