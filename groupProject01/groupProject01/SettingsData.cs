using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace groupProject01
{
 
    public enum theme
    {
        normal = 1,
        dark = 2,
    }
    public enum keys
    {
        userName = "userName";
        password = "password";

    }
     class SettingsData
    {
        private ICredentials credService;
         SettingsData(){
            //this will run whenever the page is loaded
            credService = DependencyService.Get<ICredentials>();
        }

        //TODO dont hardcode this...really thought DONT put this in production
        private string userName = "testUser";
        private string password = "password1234"; //the 4 makes it safe

        #region CREDENTIALS 
        //2 versions of setCredentials, one uses enums, one allows custom keys
        public void setCredentials(keys key, string value){
            credService.setPrefs(key, value);
        }
        public void setCredentials(string key, string value){
            credService.setPrefs(key, value);
        }
        public string getCredentials(string key){
            return credService.getPrefs(key);
        }
        #endregion

        //this will probably be hardcoded, for now this doesn't point to anything dont use it
        private string serverAddress = "72.207.1685554555258";

        public string getPassword()
        {
            if(password==null){
				getCredentials(keys.password);
            }
            return password;
        }
        public string getUserName()
        {
            if(userName==null){
                getCredentials(keys.userName);
            }
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
