using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace groupProject01
{
	public partial class MainPage : ContentPage
	{
        ICredentials service;
		public MainPage()
		{
            //error on iphone
			InitializeComponent();
            service = DependencyService.Get<ICredentials>();
		}

        async void OnRetrieve(object sender, EventArgs e)
        {
            RestService r = new RestService();
            string test = await (r.GetCall("null"));
            textField.Text = service.getPrefs("test");

        }
        void OnSave(object sender, EventArgs e)
        {
            service.setPrefs("test", textField.Text);
            
        }
    }
}
