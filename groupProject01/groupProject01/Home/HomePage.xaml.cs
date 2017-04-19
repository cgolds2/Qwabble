using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class HomePage : ContentPage
	{
        private GlobalData _gd;                                             //instantiates global variable GlobalData to store the global data

        public HomePage (GlobalData gd)
		{
			InitializeComponent();                                      //initializes UI objects with values provided, initializes elements
            _gd = gd;                                                   //sets private instance of global data
        }

        public void onRoomateClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
