using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee
    {
        string job;
        public string Job { get; private set; }

        public virtual float CostPerShift { get; }

        static bool WorkTheNextShift()
        {
            return false;
        }

        protected virtual void DoJob()
        {
           
        }

    }
}
