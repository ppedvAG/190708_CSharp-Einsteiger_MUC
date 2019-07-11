using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class CustomRandom : Random
    {
        public int NextInclusive(int minValue, int maxValue)
        {
            return base.Next(minValue, maxValue + 1);
        }
    }
}
