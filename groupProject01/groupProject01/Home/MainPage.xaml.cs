using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace groupProject01
{
	public partial class MainPage : ContentPage
	{
        ICredentials service;
        GlobalData _gd;




		public MainPage(GlobalData gd)
		{
            _gd = gd;
			InitializeComponent();

            service = DependencyService.Get<ICredentials>();
		}

        async void OnRetrieve(object sender, EventArgs e)
        {
            List<ListItemObject> lis = await (ServerHandeler.getList(1, _gd));
            //try
            //{
            //    ListItemObject l = new ListItemObject();
            //    l.Name = "Test";
            //    l.ID = 0;
            //    l.Type = 0;
            //    //RestService r = new RestService();
            //    string test = await (ServerHandeler.sendList(l));
            //    dynamic jsonDe = JsonConvert.DeserializeObject(test);
            //    textField.Text = jsonDe.name;
            //}
            //catch (Exception ex)
            //{
            //    textField.Text = ex.Message;
            //}
           

        }
        void OnSave(object sender, EventArgs e)
        {
            service.setPrefs("test", textField.Text);
            
        }
        async void OnSetting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.SettingsPage());

        }
        async void OnList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.ListsPage(_gd));

        }
        async void OnCalendar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.CalendarPage(_gd));

        }
        async void OnMessaging(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.MessagingPage(_gd));

        }
        async void OnHome(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.HomePage(_gd));

        }
        async void OnLogin(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.LoginPage(_gd));

        }
        async void OnServer(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.ServerTester());

        }
    }
}
