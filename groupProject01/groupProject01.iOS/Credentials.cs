using Foundation;
using groupProject01;
using groupProject01.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Credentials))]
namespace groupProject01.iOS
{
    class Credentials : ICredentials
    {
        public string getPrefs(string key)
        {
            return NSUserDefaults.StandardUserDefaults.StringForKey(key);
        
        }

        public void setPrefs(string key, string value)
        {
            NSUserDefaults.StandardUserDefaults.SetString(value, key);
        }
    }
}
