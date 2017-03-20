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

       


        public ListsPage()
        {

            InitializeComponent();

            lists = new ObservableCollection<ListsViewModel>();
            lists.Add(new ListsViewModel { Name = "Grocery", On = true, ID = 0 });
            lists.Add(new ListsViewModel { Name = "Shared Items", On = false, ID = 1 });
            lists.Add(new ListsViewModel { Name = "Chores", On = true, ID = 2 });
            lists.Add(new ListsViewModel { Name = "Repairs", On = true, ID = 3 });
            lstView.ItemsSource = lists;

        }



        void SwitchToggled(object sender, EventArgs e)
        {
            // Do stuff
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

   

    public class ListsViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool On { get; set; }
    }



}
