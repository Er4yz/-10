using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShuttleEngines
{
    public partial class SpaceShuttle
    {
        private void ExecuteOrbitalBurn(double burnTimeSeconds, double thrustPower, double hullIntegrity)
        {
            double flue = burnTimeSeconds * thrustPower * 2.5;

            if (flue < 0) Console.WriteLine("Топливо недостаточно!");

            else if (flue > 0 && flue >= 50)
            {
                flue = flue - 50;
                hullIntegrity = hullIntegrity * 0.1;

                Console.WriteLine($"Остаток топлива - [{flue}]");
                Console.WriteLine($"Износ корпуса  - [{hullIntegrity}]");

            }

            else Console.WriteLine("Топливо недостаточно для пуска");




        }

        private double PerformAtmosphericEntry(int hullIntegrity, double OxygenHours)
        {
            Random rnd = new Random();

            hullIntegrity = rnd.Next(3, 11);
            Console.WriteLine($"Прочность снизилась на {hullIntegrity}");

            OxygenHours = OxygenHours - 1.5;

            return hullIntegrity;
        }
    }


}
