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

        public void addItem()
        {
            throw new NotImplementedException();
        }

        public void deleteItem()
        {
            throw new NotImplementedException();
        }

        public void completeItem()
        {
            throw new NotImplementedException();
            //TODO make sure not accessible during shared items view
        }
        
        /// <summary>
        /// This sets which roommate is in charge of the specific task.
        /// </summary>
        public void modifyOwner()
        {
            throw new NotImplementedException();
        }
	}
}
