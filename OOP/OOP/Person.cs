using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public string Vorname;
        public string Nachname;
        public DateTime Geburtsdatum;
        public Person()
        {

        }
        public Person(string vorname) : this(vorname, "")
        {
        }
        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        // Eine Methode zur Beschreibung einer Person
        public string BeschreibeMich()
        {
            return $"Hallo, ich bin {Vorname} {Nachname}";
        }
        public string Lesen()
        {
            return "ich lese";
        }
    }
}
