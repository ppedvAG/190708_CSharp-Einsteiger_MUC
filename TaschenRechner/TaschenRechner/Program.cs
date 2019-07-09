using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenRechner
{
    class Program
    {
        static void Main(string[] args)
        {

            Math.Cos(5.00);


            Rechner meinRechner = new Rechner();
            Console.WriteLine(meinRechner.dividieren(10, 0));
            Program programInstanz = new Program();
            programInstanz.erstellen();
            Console.ReadLine();

            //Rechner.addiere(1, 2);
        }
        public void erstellen()
        {
            Console.WriteLine("Hallo");
        }
    }
}
