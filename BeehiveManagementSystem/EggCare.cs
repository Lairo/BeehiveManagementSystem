﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class EggCare : Bee
    {
        public override float CostPerShift { get { return 1f; } }

        protected override void DoJob()
        {
            base.DoJob();
        }

    }
}
