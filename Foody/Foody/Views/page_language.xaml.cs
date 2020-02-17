using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Foody.Views
{
    public partial class page_language : ContentPage
    {
        public page_language()
        {
            InitializeComponent();
            Uri immaroc = new Uri("https://image.flaticon.com/icons/svg/2151/2151353.svg");
            btnarabe.ImageSource = ImageSource.FromUri(immaroc);
            btnarabe.Clicked += btn_lang;
            
        }
        private async void btn_lang(object sender,EventArgs e)
        {
           await  Navigation.PushModalAsync(new page_Registration());

        }
    }
}
