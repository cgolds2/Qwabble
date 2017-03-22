using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01.Lists
{

    public partial class ListItemPage : ContentPage
	{
        public ObservableCollection<ListsViewModel> items { get; set; }


        public ListItemPage (int ListID, ListsData ld )
		{
            InitializeComponent ();

            items = new ObservableCollection<ListsViewModel>();
            items.Add(new ListsViewModel { Name = "Bananas", On = true, ID = 0 });
            items.Add(new ListsViewModel { Name = "Shared Items", On = false, ID = 1 });
            items.Add(new ListsViewModel { Name = "Chores", On = true, ID = 2 });
            items.Add(new ListsViewModel { Name = "Repairs", On = true, ID = 3 });
            lstView.ItemsSource = items;
        }

        
	}

    public class ListsViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool On { get; set; }
    }
}
