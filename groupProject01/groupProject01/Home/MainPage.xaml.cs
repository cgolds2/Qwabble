using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace groupProject01
{
	public partial class MainPage : ContentPage                 //MainPage class
	{
        ICredentials service;                                   //service global variable intialized
        GlobalData _gd;                                         //global data global variable initialized

		public MainPage(GlobalData gd)                          //MainPage Constructor
		{
            _gd = gd;
			InitializeComponent();
            service = DependencyService.Get<ICredentials>();   //how to call platform-specific code
		}

        async void OnRetrieve(object sender, EventArgs e)       //OnRetrieve method
        {

            RestService r = new RestService(); //getter and poster for server
            string test = await (r.GetCall("getUserInfo.php?username=test&userID=1")); //TESTING
            dynamic jsonDe = JsonConvert.DeserializeObject(test); //TESTING
            textField.Text = jsonDe.name;   //TESTING- set label
            //await Navigation.PushAsync(new groupProject01.ListsPage());
            //textField.Text = service.getPrefs("test");

        }

        void OnSave(object sender, EventArgs e)                 //OnSave method
        {
            service.setPrefs("test", textField.Text);           //testing if things save
        }

        async void OnSetting(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupProject01.SettingsPage());

        }
        async void OnList(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new groupProject01.ListsPage(_gd)));

        }
        async void OnCalendar(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupProject01.CalendarPage(_gd));

        }
        async void OnMessaging(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new groupProject01.MessagingPage(_gd));


        }
    }
}
