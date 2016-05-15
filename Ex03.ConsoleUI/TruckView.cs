using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class TruckView
    {

        public static string GetTruckView(Truck i_Truck)
        {
            return string.Format(
                VehicleViewTextTemplates.k_TruckViewTemplate,
                i_Truck.r_IsCarryingHazardousMaterials,
                i_Truck.r_MaxWeightAllowed);
        }

        public static Truck CreateTruckDialog(
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            bool isCarryingHazMats;
            float maxWeight;

            GetTruckInfo(out isCarryingHazMats, out maxWeight);

            return VehicleFactory.CreateTruck(
                i_TiresManufacturer,
                i_ModelName,
                i_LicenseNumber,
                isCarryingHazMats,
                maxWeight);
        }

        /// <summary>
        /// Get truck additional info needed for factory
        /// </summary>
        /// <param name="i_IsCarryingHazMats"></param>
        /// <param name="i_MaxWeight"></param>
        private static void GetTruckInfo(out bool i_IsCarryingHazMats, out float i_MaxWeight)
        {
            Console.WriteLine("Please select car color: ");
            i_IsCarryingHazMats = InputUtils.GetBooleanFromConsole('t', 'f');

            Console.Write("Please select number of doors: ");
            i_MaxWeight = InputUtils.GetFloatFromConsole();
        }
    }
}
