using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    //credentials = https://developer.xamarin.com/recipes/cross-platform/xamarin-forms/general/store-credentials/
 
    public enum theme
    {
        normal = 1,
        dark = 2,
    }
     class SettingsData
    {
        //TODO dont hardcode this...really thought DONT put this in production
        private string userName = "testUser";
        private string password = "password1234"; //the 4 makes it save
        public static void storeCredentials(string key, string value)
        {

        }
        //this will probably be hardcoded
        private string serverAddress = "72.207.1685554555258";

        public string getPassword()
        {
            return password;
        }
        public string getUserName()
        {
            return userName;
        }

        public void changeTheme(theme defaultTheme)
        {
            
        }
        public void changeTheme(int customTheme)
        {

        }
    }
}
