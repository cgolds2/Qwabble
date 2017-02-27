using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using groupProject01.Droid;

[assembly: Dependency(typeof(Credientials))]
namespace groupProject01.Droid
{
    class Credientials : ICredentials
    {
      

        void ICredentials.setPrefs(string key, string value)
        {
            //store
            var prefs = Android.App.Application.Context.GetSharedPreferences("MyApp", FileCreationMode.Private);
            var prefEditor = prefs.Edit();
            prefEditor.PutString(key, value);
            prefEditor.Commit();
        }

        string ICredentials.getPrefs(string key)
        {
            try
            {
                //retreive 
                var prefs = Android.App.Application.Context.GetSharedPreferences("MyApp", FileCreationMode.Private);
                var somePref = prefs.GetString(key, null);
                return somePref;
            }
            catch (Exception)
            {

                return "Error";
            }

        }
    }
}