using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungZwei
{
    public class Sachbearbeiter : Person
    {
        public override string Bearbeiten()
        {
            return "Sachbearbeiter" + base.Bearbeiten();
        }
    }
}
