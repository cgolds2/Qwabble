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
        //TODO On Start, all edit buttons are set to hidden and disabled.
		public ListsPage ()
		{
			InitializeComponent ();
		}

        /// <summary>
        /// This will make hide, add, and delete visible on the form. The user will not be allowed to select any lists from this view.
        /// </summary>
        /// <param name="sender"> reference to the edit button </param>
        /// <param name="e"> the event data </param>
        public void onEditClicked(object sender, EventArgs e)
        {
            //enable view and actions of hide, add, delete
            /* if(list.Creator = curUser){
             *      delete.Enabled = true;
             *      delete.Visible = true;
             * }
             * else{
             *      hide.Enabled = true;
             *      hide.Visible = true;
             * }
             * 
             * add.Enabled = true;
             * add.Visible = true;
             */

            //TODO dont allow to select any lists
        }

        /// <summary>
        /// This is an event handler to see if a button was clicked and do the appropriate action for the button type.
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event </param>
        /// <param name="e"> event data </param>
        public void onVisibilityClicked(object sender, EventArgs e)
        {
            // TODO make sure the button sends the appropriate information for sender
            //Button btn = (Button)sender;

            ////When hide is clicked, the list will be hidden for user. This option will only be available if list was not created by user.
            //if(btn.Tag == "HideList")
            //{
            //    //hide particular list for only this user-- this means we need to pass in listId with this
            //    //make sure only works for lists not created by user
            //}
            ////When delete list is clicked, the form will delete the list. This option will only be available for lists created by user. 
            //else if(btn.Tag == "DeleteList")
            //{
            //    //check if list was created by user
            //    //if true, delete(list) from all user views
            //}
            ///*when add list is clicked, the form will create a new list, allowing user to set it as private vs public, select the type of list(?), and put in the necessary beginning information (title and item fields: not limited for initial creation)*/
            //else if(btn.Tag == "AddList")
            //{
            //    //ask user if they would like list to be private vs public -- new menu?
            //    //select the type of list from preselected (grocery, shared items, chores, repairs) or custom
            //    //bring to initial screen that allows them to use title and put in items
            //    //allow user to click done and make visible for the appropriate people (see: private vs public)
            //}
            throw new NotImplementedException();
        }
	}
}
