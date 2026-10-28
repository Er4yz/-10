using SpaceShuttleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Designer designer = new Designer();

            Console.WriteLine($"Имя: '{designer.ShuttleName}'.\nТопливо: {designer.FuelKg} кг.\nКислород: {designer.OxygenHours} ч.\nКорпус: {designer.HullIntegrity}%");

            SpaceShuttle spaceShuttle = new SpaceShuttle();

            spaceShuttle.CheckSystems();


        }
    }
}
