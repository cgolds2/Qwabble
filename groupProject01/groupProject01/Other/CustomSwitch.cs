using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace groupProject01
{
    public class CustomSwitch : Switch
    {
        public static readonly BindableProperty IDProperty =
            BindableProperty.Create("ID", typeof(int), typeof(Switch), -1);

        public int ID 
        {
            get { return (int)GetValue(IDProperty); }
            set { SetValue(IDProperty, value); }
        }

    }
}
