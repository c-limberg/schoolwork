using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbergProjekt
{
    class GameData                          //Klasse zur Speicherung der Spieldaten aus der Datenbank
    {
        private int id;
        private string country;
        private string capital;

        public GameData(int id, string country, string capital)
        {
            Id = id;
            Country = country;
            Capital = capital;
        }

        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public string Capital { get => capital; set => capital = value; }
    }
}
