using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee
    {
        readonly string StatusReport;

        public override float CostPerShift { get { return 1.95f; } }

        private Bee[] workers = new Bee[0];

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
