using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    public class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
