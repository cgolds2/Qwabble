using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class ViewListItemPage : ContentPage
	{
		public ViewListItemPage ()
		{
			InitializeComponent ();
		}

        public void onAddItemClicked(object Sender, EventArgs e)
        {
            addItem();
            throw new NotImplementedException();
        }

        public void onDeleteItemClicked(object Sender, EventArgs e)
        {
            deleteItem();
            throw new NotImplementedException();
        }

        public void onCompleteItemClicked(object Sender, EventArgs e)
        {
            completeItem();
            throw new NotImplementedException();
        }
        
        public void onChangeOwnerClicked()
        {
            modifyOwner();
            throw new NotImplementedException();
        }

    }
}
