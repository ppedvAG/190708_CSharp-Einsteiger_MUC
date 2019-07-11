using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungZwei
{
    class Program
    {
        static void Main(string[] args)
        {
            Formular form1 = new Formular();
            Console.WriteLine(form1.Ausfüllen());


            Console.ReadLine();
        }
    }
}
