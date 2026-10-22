using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShuttle.Engines
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

        private double PerformAtmosphericEntry(int hullIntegrity, double oxygenHours)
        {
            Random rnd = new Random();

            hullIntegrity = rnd.Next(10,26);
            Console.WriteLine($"Прочность снизилась на {hullIntegrity}");

            oxygenHours = rnd.Next(3000, 5000);
            oxygenHours = oxygenHours - 1.5;

            return hullIntegrity;
        }
    }

    
}
