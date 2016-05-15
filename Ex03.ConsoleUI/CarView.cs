using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class CarView
    {


        public static string GetCarView(Car i_Car)
        {
            return string.Format(VehicleViewTextTemplates.k_CarViewTemplate, i_Car.r_Color, i_Car.r_DoorsCount);
        }

        public static Car CreateCarDialog(
            VehicleFactory.eVehicleCatalogue i_SelectedType,
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            Car result;
            Car.eCarColor color;
            int doorsCount;

            GetCarInfo(out color, out doorsCount);

            if (i_SelectedType == VehicleFactory.eVehicleCatalogue.ElectricCar)
            {
                result = VehicleFactory.CreateElectricCar(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    color,
                    doorsCount);
            }
            else
            {
                result = VehicleFactory.CreatePetrolCar(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    color,
                    doorsCount);
            }

            return result;
        }

        /// <summary>
        /// Get car info needed for factory from user
        /// </summary>
        /// <param name="i_Color"></param>
        /// <param name="i_DoorsCount"></param>
        private static void GetCarInfo(out Car.eCarColor i_Color, out int i_DoorsCount)
        {
            Console.WriteLine("Please select car color: ");
            i_Color = (Car.eCarColor)InputUtils.GetEnumSelectionFromType<Car.eCarColor>();

            Console.Write("Please select number of doors: ");
            i_DoorsCount = InputUtils.GetIntFromConsole();
        }
    }
}
