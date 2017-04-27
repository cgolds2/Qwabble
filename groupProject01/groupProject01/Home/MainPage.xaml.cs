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
            //DEPRECIATED
            NavigationPage.SetHasNavigationBar(this, false);

            //Children.Add(new groupProject01.CalendarPage(_gd));
            //Children.Add(new groupProject01.ListsPage(_gd));
            //Children.Add(new groupProject01.MessagingPage(_gd));
            //Children.Add(new groupProject01.SettingsPage(_gd));

            _gd = gd;
			InitializeComponent();
            var existingPages = Navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
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
              Application.Current.MainPage = new groupProject01.SettingsPage(_gd); 
           // CurrentPage = Children[1];
        }
        async void OnList(object sender, EventArgs e)
        {
             Application.Current.MainPage = new groupProject01.ListsPage(_gd);

        }
        async void OnCalendar(object sender, EventArgs e)
        {
             Application.Current.MainPage = new groupProject01.CalendarPage(_gd);

        }
        async void OnMessaging(object sender, EventArgs e)
        {

          Application.Current.MainPage = new groupProject01.MessagingPage(_gd);
        }
        async void OnHome(object sender, EventArgs e)
        {

            Application.Current.MainPage = new groupProject01.HomePage(_gd);

        }

    }
}
