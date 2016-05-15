using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    class VehicleViewTextTemplates
    {
        public const string k_VehicleViewTemplate = @"----------------------------------
Vehicle:
{0}
Owner:
{1}
Tires:
{2}
Vehicle power source:
{3}
Vehicle specific details:
{4}
----------------------------------
";

        public static string k_TruckViewTemplate = @"Carrying hazardous materials : {0}
Weight limit: {1}";
        public const string k_TirePairTemplate = @"{0,-20} {1}
";
        public const string k_TireAirPressureTemplate = "{0}/{1}";
        public const string k_TireManufecturerHeaderText = "Manufacturer";
        public const string k_TireAirPressureHeaderText = "Air pressure";
        public const string k_TireColumnUnderlineText = "------------";
        public const string k_PetrolPowerSourceViewTemplate = @"Fuel left : {0}/{1}
Fuel type: {2}";
        public static string k_MotorcycleViewTemplate = @"License type : {0}
Engine volume (cc): {1}";
        public const string k_FullDetailsTemplate = @"License number: {0}
Model name: {1}";
        public const string k_ElectricPowerSourceViewTemplate = @"Hours Left : {0}/{1}";

        public static string k_CarViewTemplate = @"Car color : {0}
Number of doors: {1}";
        public const string k_OwnerVehicleViewTemplate = @"Owner name: {0}
Vehicle status: {1}";
    }
}
