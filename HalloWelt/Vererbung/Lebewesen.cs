using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Lebewesen
    {
        public string Alter { get; set; }

        public Lebewesen(string alter)
        {
            Alter = alter;
        }
    }
}
