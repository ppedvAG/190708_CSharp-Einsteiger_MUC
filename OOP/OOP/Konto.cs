using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public class Konto
    {
        private decimal kontostand;

        public decimal Kontostand
        {
            get
            {
                return kontostand;
            }
            // Kontostand darf innerhalb meines Programms nicht verändert werden!
            private set
            {
                kontostand = GetKontoStandAusDatenbank();
                //kontostand = value;
            }
        }
        private decimal GetKontoStandAusDatenbank()
        {
            // Logik zum Erhalten des Kontostandes
            return Convert.ToDecimal(0.00);
        }

    }
}