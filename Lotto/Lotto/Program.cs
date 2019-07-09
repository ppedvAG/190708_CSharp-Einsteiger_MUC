using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] zahlen = new int[]
            //{
            //    1,2,3,4,5,6
            //};
            //Console.WriteLine(zahlen.Contains(2));
            //Console.ReadKey();

            //double[] doubleZahlen = new double[]
            //{
            //    5,6,7,8,9,10
            //};

            //Console.WriteLine(doubleZahlen[0]);
            //doubleZahlen[0] = 3;
            string[] neuesArray = { "Daniel","Josef","Oliver","Ralf" };

            //for (int Laufvariable = 0; Laufvariable < neuesArray.Length; Laufvariable++)
            //{
            //    Console.WriteLine($"{neuesArray[Laufvariable]}");
            //}


            foreach (string Vorname in neuesArray)
            {
                Console.WriteLine($"Durchlauf von {Vorname}");
                if(Vorname == "Oliver")
                {
                    Console.WriteLine("Jetzt verlasse ich die Schleife");
                    continue;
                }
                Console.WriteLine("Jetzt bin ich am Ende angelangt und fange mit dem nächsten Durchlauf an.");
            }

            //for (int i=0; i<doubleZahlen.Length; i++)
            //{
            //    //Console.WriteLine($"{doubleZahlen[i]}");
            //}
            Console.ReadKey();
        }
    }
}
