using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class MessagingPage
	{
		public MessagingPage ()
		{
			InitializeComponent ();
		}

        /// <summary>
        /// This will bring up a menu which will allow the sender to put in info about guest and will push this info to all roommates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onGuestClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// This will bring up a chat based on which channel is selected (all, specific roommate names).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onChatClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Redirects the sender to their phone's dialer and automatically fills in specified roommates phone number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onRedirectToDialer(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends a push notification to all roommates (even with notifications muted).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onUrgentMessageClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
	}
}
