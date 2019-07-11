using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungZwei
{
    public class Formular : IEditable
    {
        Person sachbearbeiter1 = new Sachbearbeiter();

        public string BearbeitungsStatus {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Ausfüllen()
        {
            return sachbearbeiter1.Bearbeiten();
        }
    }
}
