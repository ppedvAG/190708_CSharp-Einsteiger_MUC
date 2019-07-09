using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenRechner
{
    public class Rechner // Bauplan
    {
        public int subtrahieren(int a, int b)
        {
            int differenz;
            if (a>=b)
            {
                differenz = a - b;
            } else
            {
                differenz = b - a;
            }
            return differenz;
        }
        public int addiere(int a, int b)
        {
            int summe = a + b;
            return summe;
        }
        public int multiplizieren(int a, int b)
        {
            int produkt = a * b;
            return produkt;
        }
        public double dividieren(int a, int b)
        {
            double quotient; 
            if(! (a == 0 || b == 0))
            {
                quotient = a / b;
            } else
            {
                quotient = 0;
            }
            return quotient;


        }
    }
}
