using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
        {
        }

        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public int Nectar { get; set; }
        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int length)
        {
            return 123;
        }

        public void FindFlower()
        {
            
        }
        public void GatherNectar()
        {
            
        }
        public void ReturnToHive()
        {
        
        }
    }
}
