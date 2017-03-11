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
			InitializeComponent();
            //error on iphone
            service = DependencyService.Get<ICredentials>();
		}
        void OnRetrieve(object sender, EventArgs e)
        {
            textField.Text =service.getPrefs("test");
        }
        void OnSave(object sender, EventArgs e)
        {
            service.setPrefs("test", textField.Text);
            
        }
    }
}
