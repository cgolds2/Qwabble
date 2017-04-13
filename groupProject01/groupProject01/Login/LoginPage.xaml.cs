using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class LoginPage : ContentPage
	{
        GlobalData _gd;

        public LoginPage (GlobalData gd)
		{
			InitializeComponent ();
            _gd = gd;
        }




        //await
        void OnLogin(object sender, EventArgs e)
        {
            Debug.WriteLine("Login Button Works!");
        }
    }
}
