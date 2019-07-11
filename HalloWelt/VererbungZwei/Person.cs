using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungZwei
{
    public class Person 
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public virtual string Bearbeiten()
        {
            return "Es wird bearbeitet ...";
        }
    }
}
