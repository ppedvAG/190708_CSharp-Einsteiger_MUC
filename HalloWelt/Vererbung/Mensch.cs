using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Mensch
    {
        public string Wohnort { get; set; }
        public Mensch(string alter, string wohnort)
        {
            Wohnort = wohnort;
            Console.WriteLine($"Mein Wohnort lautet: {Wohnort}, Alter: {alter}");
        }
    }
}
