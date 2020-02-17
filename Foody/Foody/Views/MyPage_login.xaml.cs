using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace Foody.Views
{
    public partial class MyPage_login : ContentPage
    {
        public MyPage_login()
        {
            InitializeComponent();

            var wi = Plugin.XamJam.Screen.CrossScreen.Current.Size.Width - 30;

        }
    }
}
