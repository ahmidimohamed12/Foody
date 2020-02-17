using System;
using Xamarin.Forms;
namespace Foody.Model
{
    public class Resturant
    {
        public int id_res { get; set; }
        public string name_rest { get; set; }
        public ImageSource[] im { get; set; }
        public string NumeroTelephone { get; set; }
        public Resturant()
        {
        }
    }
}
