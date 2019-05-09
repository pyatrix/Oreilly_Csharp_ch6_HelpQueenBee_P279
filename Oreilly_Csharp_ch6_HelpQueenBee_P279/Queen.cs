using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    class Queen
    {
        public Queen (Worker[] workers)
        {
            this.workers = workers;
        }
        private Worker[] workers;
        private int shiftNumber = 0;
        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
                return false;
            }
        }
    }
}
