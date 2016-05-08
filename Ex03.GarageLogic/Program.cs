using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Program
    {
        public static void Main()
        {
            Motorcycle m = VehicleFactory.CreateElectricMotorcycle("A", "lll", Motorcycle.eLicenseType.A, 40);
            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}
