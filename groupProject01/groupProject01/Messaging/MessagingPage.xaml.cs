﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class MessagingPage : ContentPage        //MessagingPage class
	{
        public ObservableCollection<MessagingObject> messages { get; set; } //creates an instance of messages
        private GlobalData _gd;                             //global variable GlobalData initialzed
        
        public MessagingPage (GlobalData gd)                //MessagingPage constructor
		{
			InitializeComponent ();                          //loads the UI elements
            _gd = gd;                                        //sets private instance of global data
            messages = _gd.MessagingDataInstance.messages;   //gets the messaging data from the data file
            //msgView.ItemsSource = messages;                  //sets the messaging UI
		}

        /// <summary>
         /// This will bring up a menu which will allow the sender to put in info about guest they are bringing over and will push this info to all roommates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onGuestClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


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
    }
}
