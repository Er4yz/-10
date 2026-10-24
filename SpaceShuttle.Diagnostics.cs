using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SpaceShuttle.Core;

namespace SpaceShuttle.Diagnostics
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

        private void CheckSystems(double _fuelKg, int _hullIntegrity, string systemName, string message)
        {
            if (_fuelKg < 500)
            {
                OnCriticalSystemAlert("Топливная система", "Критический остаток топлива!");
            }

            if (_hullIntegrity < 25)
            {
                OnCriticalSystemAlert("Контур обшивки", "Опасность разрушения корпуса!");
            }
        }

        public void PrintTelemetry()
        {
            Console.WriteLine("Текущие параметры коробля: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        #endregion
    }
}
