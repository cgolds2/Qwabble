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
            textField.Text = test;
          await Navigation.PushAsync(new groupProject01.ListsPage());
            //textField.Text = service.getPrefs("test");

        }
        void OnSave(object sender, EventArgs e)
        {
            service.setPrefs("test", textField.Text);
            
        }
        async void OnSetting(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupProject01.SettingsPage());

        }
        async void OnList(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupProject01.ListsPage());

        }
        async void OnCalendar(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupProject01.CalendarPage());

        }
        async void OnMessaging(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupProject01.MessagingPage());

        }
    }
}
