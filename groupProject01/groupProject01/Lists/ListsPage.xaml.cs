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
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", On = true });
            veggies.Add(new VeggieViewModel { Name = "Romaine", Type = "Vegetable", On = false });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", On = true });
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
        public string Type { get; set; }
        public bool On { get; set; }
    }



}
