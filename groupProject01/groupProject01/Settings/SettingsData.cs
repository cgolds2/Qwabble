using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace groupProject01
{
    #region ENUMS
    public enum theme
    {
        normal = 1,
        dark = 2,
    }
    public enum keysInt
    {
       userName = 1,
       password = 2,

    }
    #endregion

    public class SettingsData
    {

        private ICredentials credService;
        public SettingsData()
        {
            //this will run whenever the page is loaded
            credService = DependencyService.Get<ICredentials>();
            refreshAll();
        }

        public void refreshAll()
        {
            //throw new NotImplementedException();
        }


        public string getStringFromKey(keysInt keyInt)
        {
            switch ((int)keyInt)
            {
                case 1:
                    return "username";
                case 2:
                    return "password";
                default:
                    return "";

            }
        }

        #region CREDENTIALS 


        //TODO dont hardcode this...really thought DONT put this in production

        //2 versions of setCredentials, one uses enums, one allows custom keys
        public void setCredentials(keysInt key, string value){
            credService.setPrefs(getStringFromKey(key), value);
        }
        public void setCredentials(string key, string value){
            credService.setPrefs(key, value);
        }
        public string getCredentials(string key){
            return credService.getPrefs(key);
        }
        public string getCredentials(keysInt keyy)
        {
            return credService.getPrefs(getStringFromKey(keyy));
        }
        #endregion

        //this will probably be hardcoded, for now this doesn't point to anything dont use it
        private string serverAddress = "72.207.1685554555258";

        public string getPassword()
        {
            if(password==null){
				getCredentials(getStringFromKey(keysInt.password));
            }
            return password;
        }
        public string getUserName()
        {
            if(userName==null){
                getCredentials(getStringFromKey(keysInt.userName));
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
