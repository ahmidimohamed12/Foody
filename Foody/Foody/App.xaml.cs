using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foody.Views;

namespace Foody
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new page_pays_();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
