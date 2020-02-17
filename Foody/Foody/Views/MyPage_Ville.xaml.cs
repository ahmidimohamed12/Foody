using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Foody.Views
{
    public partial class MyPage_Ville : ContentPage
    {
        public string ville = "nador,fes,casablanca,rabat,";
        public MyPage_Ville()
        {
            InitializeComponent();
            string[] k = ville.Split(',');
            List<string> p = new List<string>();
            for(int i = 0;i <k.Length;i++ )
            {
                p.Add(k[i]);
            }
            ls.ItemsSource =p;
       }
    }
}
