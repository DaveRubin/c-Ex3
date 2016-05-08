using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Program
    {
        public static void Main()
        {
            ElectricMotorCycle m = VehicleFactory.CreateElectricMotorcycle("bzzzzMobile", "123", Motorcycle.eLicenseType.A, 40);
            m.PowerSource.Charge(-10);
            PetrolMotorCycle m2 = VehicleFactory.CreatePetrolMotorCycle("kawasakaki", "321", Motorcycle.eLicenseType.B1, 40);
            m2.PowerSource.Fuel(m2.PowerSource.r_FeulType,-50);
            Truck t = VehicleFactory.CreateTruck("trucky truck", "123456789", false, 50);
            t.PowerSource.Fuel(t.PowerSource.r_FeulType,-20);
            PetrolCar car1 = VehicleFactory.CreatePetrolCar("dodge", "=-=-=", Car.eCarColor.Black, 4);
            car1.PowerSource.Fuel(car1.PowerSource.r_FeulType,-20);
            ElectricCar car2 = VehicleFactory.CreateElectricCar("honda", "[][][][]", Car.eCarColor.White, 2);
            car2.PowerSource.Charge(-40);
            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}
