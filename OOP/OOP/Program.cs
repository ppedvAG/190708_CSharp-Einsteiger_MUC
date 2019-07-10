using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Person buchAutor = new Person("Josef");


            //Buch meinBuch = new Buch();
            //meinBuch.Preis = 12.99f;

            Buch josefsBuch = new Buch(buchAutor);
            Console.WriteLine($"Wer ist der Autor des Buches? {josefsBuch.Autor.Vorname}");
            

            //meinBuch.Titel = "Mein Buch";
            //Console.WriteLine(meinBuch.Titel);
            //meinBuch.Titel = "Mein Buch";

            //meinBuch.SetTitel("Mein Buch");
            //Console.WriteLine(meinBuch.GetTitel());

            //Console.WriteLine(Convert.ToDateTime("01.01.1985"));

            //Person Ralf = new Person("Ralf");
            //Person Ralf = new Person("Ralf", "Gottschalk");
            //Person Ralf = new Person("Ralf", "Gottschalk", Convert.ToDateTime("01.01.1980"));
            //Person Ralf = new Person(5);
            //Ralf.Vorname = "Ralf";
            //Ralf.Nachname = "Gottschalk";
            //Console.WriteLine(Ralf.BeschreibeMich());

            Console.ReadKey();
        }

    }
}
