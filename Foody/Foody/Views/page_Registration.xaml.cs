using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Foody.Model;

namespace Foody.Views
{
    public partial class page_Registration : ContentPage
    {
        public string m ;
        public page_Registration()
        {
            InitializeComponent();
            btnimage.Clicked += btn_image;
            var wi = (Plugin.XamJam.Screen.CrossScreen.Current.Size.Width / 2) - 40;
        }

        private async void btn_image(object sender,EventArgs e)
        {
            try
            {
                var a = await Plugin.FilePicker.CrossFilePicker.Current.PickFile();
                var pt = a.FilePath;
                m = a.FileName;
            }catch(Exception)
            {

            }
          //  await DisplayAlert("Information","ok","ok",pt.ToString());

            /*
            if (pt == ".png")
            {
                btnimage.IsVisible = false;
                //Image im = new Image();
                //im.Source = ImageSource.FromFile(a.FilePath);

            }
            else
            {
                await DisplayAlert("Information", "Image Invalide", "Ok");
            }
            */
        }
        private void btn_click(object sender,EventArgs e)
        {
            User user = new User();
            user.nom = txtnom.Text.ToLower();
            user.prenom = txtprenom.Text.ToLower();
            user.Email = txtEmail.Text;
            user.im = m;
        }
    }
}
