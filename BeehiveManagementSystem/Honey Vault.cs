using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        static readonly string StatusReport;

        const float NECTAR_CONVERSION_RATIO = .19f;
        const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;

        static void ConvertNectarToHoney(float amount)
        {
            if (amount < nectar)
            {
                nectar += amount;
            }
            else
            {
                honey += nectar - amount * NECTAR_CONVERSION_RATIO;
            }

        }

        static bool ConsumeHoney(float amount)
        {
            if (amount > honey)
            {
                honey -= amount;
                return true;

            }
            return false;
        }

        static void CollectNectar(float amount)
        {
            if (amount > 0)
            {
                nectar += amount;
            }
        }

        public static string SatusReport
        {
            get
            {
                if (honey < LOW_LEVEL_WARNING)
                {
                    return "\nLOW HONEY - ADD A HONEY MANUFACTURER\n";
                }
                if (nectar < LOW_LEVEL_WARNING)
                {
                    return "\nLOW NECTAR - ADD A NECTAR COLLECTOR\n";
                }
                return "\n";
            }

        }
    }
}
