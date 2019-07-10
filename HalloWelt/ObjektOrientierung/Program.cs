using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrientierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug BMW = new Fahrzeug();

            BMW.Preis = 19.999;
            BMW.Name = "Audi";
            BMW.BeschreibeMich();

            BMW.StarteMotor();

            BMW.Beschleunigen(10);
            BMW.BeschreibeMich();


            Console.WriteLine("--- ENDE ---");
            Console.ReadLine();
        }
    }
}
