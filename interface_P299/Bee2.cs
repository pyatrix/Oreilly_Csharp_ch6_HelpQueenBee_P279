using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    class Bee2 : IStingPatrol
    {
        public int AlertLevel { get; }

        public int StingerLength { get ; set ; }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return 123;
        }
    }
}
