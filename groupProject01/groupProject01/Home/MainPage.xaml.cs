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
            NavigationPage.SetHasNavigationBar(this, false);

            _gd = gd;
			InitializeComponent();

            service = DependencyService.Get<ICredentials>();
		}

        async void OnRetrieve(object sender, EventArgs e)
        {
            //List<ListItemObject> lis = await (ServerHandeler.getList(_gd));
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
        
        async void OnSetting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.SettingsPage(_gd),false);
        }
        async void OnList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.ListsPage(_gd),false);

        }
        async void OnCalendar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.CalendarPage(_gd),false);

        }
        async void OnMessaging(object sender, EventArgs e)
        {

          await Navigation.PushAsync(new groupProject01.MessagingPage(_gd),false);
        }
        async void OnHome(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.HomePage(_gd),false);

        }
        async void OnLogin(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.LoginPage(_gd),false);

        }
        async void OnServer(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.Settings.ServerTester(),false);

        }
        async void OnInitial(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.InitialPage(_gd),false);

        }
    }
}
