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
        public ObservableCollection<VeggieViewModel> veggies { get; set; }

       


        public ListsPage()
        {

            InitializeComponent();

            veggies = new ObservableCollection<VeggieViewModel>();
            veggies.Add(new VeggieViewModel { Name = "Grocery", On = true, ID = 1 });
            veggies.Add(new VeggieViewModel { Name = "Romaine", On = false, ID = 2 });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", On = true, ID = 3 });
            lstView.ItemsSource = veggies;

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

   

    public class VeggieViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool On { get; set; }
    }



}
