using System;
using Xamarin.Forms;
using System.Collections.Generic;
namespace Foody.Model
{
    public class User
    {
        public int id_user { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string Email { get; set; }
        public string NumeroTele { get; set; }
        public ImageSource im { get; set; }
        public string password1 { get; set; }
        public string password2 { get; set; }
        public List<Command> commands = new List<Command>();
        public User()
        {
        }
    }
}
