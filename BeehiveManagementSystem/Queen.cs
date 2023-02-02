using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee
    {
        private const float EGGS_PER_SHFIT = 0f;
        readonly string StatusReport;

        public override float CostPerShift { get { return 1.95f; } }

        private Bee[] workers = new Bee[0];

        private void AddWorker(Bee worker)
        {
            if(unassignedWorker >= 1)
            {
                unassignedWorker--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length] = worker;
            }
        }
        public void AssignBee()
        {

        }

        public void CareForEggs()
        {

        }

        protected override void DoJob()
        {
            base.DoJob();
        }

    }
}
