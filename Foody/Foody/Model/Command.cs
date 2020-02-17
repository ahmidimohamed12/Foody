using System;
namespace Foody.Model
{
    public class Command
    {
        public int id_command { get; set; }
        public string Name_command { get; set; }
        public double prix_command { get; set; }
        public int qt { get; set; }

        public Command()
        {
        }
    }
}
