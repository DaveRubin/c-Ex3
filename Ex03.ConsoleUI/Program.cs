using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            /*
//            Vehicle m = VehicleFactory.CreateElectricMotorcycle("a","bzzzzMobile", "123", Motorcycle.eLicenseType.A, 40);
//            m.PowerSource.Charge(-10);
            PetrolMotorCycle m2 = VehicleFactory.CreatePetrolMotorCycle("a", "kawasakaki", "321", Motorcycle.eLicenseType.B1, 40);
//            m2.PowerSource.Fuel(m2.PowerSource.r_FeulType,-50);
            Vehicle t = VehicleFactory.CreateTruck("a", "trucky truck", "123456789", false, 50);
//            t.PowerSource.Fuel(t.PowerSource.r_FeulType,-20);
            Vehicle car1 = VehicleFactory.CreatePetrolCar("a", "dodge", "=-=-=", Car.eCarColor.Black, 4);
//            car1.PowerSource.Fuel(car1.PowerSource.r_FeulType,-20);
            ElectricCar car2 = VehicleFactory.CreateElectricCar("a", "honda", "[][][][]", Car.eCarColor.White, 2);
//            car2.PowerSource.Charge(-40);
            VehicleOwner owner1 = new VehicleOwner("David rubin","123456789");
            VehicleOwner owner2 = new VehicleOwner("Chick man","123456789");
            VehicleOwner owner3 = new VehicleOwner("KOKO & SHOOGIE","123456789");
            VehicleRecord a = new VehicleRecord(m, owner1);
            VehicleRecord b = new VehicleRecord(car1, owner2);
            VehicleRecord c = new VehicleRecord(t, owner3);

            VehicleView.PrintFullDetails(a);
            VehicleView.PrintFullDetails(b);
            VehicleView.PrintFullDetails(c);

            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
             */
            GarageSystem garageSystem = new GarageSystem();
        }
    }
}
