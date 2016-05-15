using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class MotorcycleView
    {
        public static Motorcycle CreateMotorcycleDialog(
            VehicleFactory.eVehicleCatalogue i_SelectedType,
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            Motorcycle result;
            Motorcycle.eLicenseType licenseType;
            int engineVolume;

            GetMotorcycleInfo(out licenseType, out engineVolume);

            if (i_SelectedType == VehicleFactory.eVehicleCatalogue.ElectricMotorCycle)
            {
                result = VehicleFactory.CreateElectricMotorcycle(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    licenseType,
                    engineVolume);
            }
            else
            {
                result = VehicleFactory.CreatePetrolMotorCycle(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    licenseType,
                    engineVolume);
            }

            return result;
        }

        /// <summary>
        /// Get motorcycle additional info needed for factory
        /// </summary>
        /// <param name="i_LicenseType"></param>
        /// <param name="i_EngineVolume"></param>
        private static void GetMotorcycleInfo(out Motorcycle.eLicenseType i_LicenseType, out int i_EngineVolume)
        {
            Console.WriteLine("Enter License type: ");
            i_LicenseType = (Motorcycle.eLicenseType)InputUtils.GetEnumSelectionFromType<Motorcycle.eLicenseType>();

            Console.Write("Enter engine volume: ");
            i_EngineVolume = InputUtils.GetIntFromConsole();
        }

        public static string GetMotorCycleView(Motorcycle i_Motorcycle)
        {
            return string.Format(
                VehicleViewTextTemplates.k_MotorcycleViewTemplate,
                i_Motorcycle.r_LicenseType,
                i_Motorcycle.r_EngineVolume);
        }
    }
}
