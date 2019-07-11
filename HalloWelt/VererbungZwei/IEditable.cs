using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungZwei
{
    interface IEditable
    {
        string BearbeitungsStatus { get; set; }
        string Ausfüllen();
    }
}
