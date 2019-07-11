using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lebewesen Mensch = new Mensch("30","München");

            Mensch Mensch = new Mensch("2222", "IUrgendwo");



            Console.WriteLine(Mensch.GetType());
            Console.ReadKey();
        }
    }
}
