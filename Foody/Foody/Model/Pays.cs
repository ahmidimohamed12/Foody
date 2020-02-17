using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace Foody.Model
{
    public class Pays
    {
        public int id_pays { get; set; }
        public string name_pays { get; set; }
        public List<Ville> villes = new List<Ville>();
        public ImageSource image_drapeu;
        public Pays()
        {
        }
    }
}
