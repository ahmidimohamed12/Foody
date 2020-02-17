using System;
using System.Collections.Generic;
namespace Foody.Model
{
    public class Ville
    {
        public int id_ville { get; set; }
        public string ville_name { get; set; }
        public List<Resturant> resturants = new List<Resturant>();
        public Ville()
        {
        }
    }
}
