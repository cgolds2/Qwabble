using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class ListsPage : ContentPage
	{
		public ListsPage ()
		{
			InitializeComponent ();
		}

        public void onListTypeClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void onHideListClicked(object Sender, EventArgs e)
        {
            hideList();
            throw new NotImplementedException();
        }

        public void onDeleteListClicked(object Sender, EventArgs e)
        {
            deleteList();
            throw new NotImplementedException();
        }

        public void onAddListClicked(obj Sender, EventArgs e)
        {
            //TODO pass in type of list- private vs public?
            addList();
            throw new NotImplementedException();
        }
	}
}
