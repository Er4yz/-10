using SpaceShuttleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShuttleDiagnostics
{
    #region Частичный метод

    public partial class SpaceShuttle
    {
        partial void OnCriticalSystemAlert(string systemName, string message);

        partial void OnCriticalSystemAlert(string systemName, string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Тревога! {systemName}, {message}");
            Console.ResetColor();
        }

        #endregion

        #region Методы

        public void CheckSystems(double fuelKg, int hullIntegrity, string systemName, string message)
        {
            if (fuelKg < 500)
            {
                OnCriticalSystemAlert("Топливная система", "Критический остаток топлива!");
            }

            if (hullIntegrity < 25)
            {
                OnCriticalSystemAlert("Контур обшивки", "Опасность разрушения корпуса!");
            }
        }

        public void PrintTelemetry()
        {
            Designer designer = new Designer();
        }

        #endregion
    }
}
