using System;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class VehicleView
    {
        /// <summary>
        /// Print full details of a vehicle
        /// </summary>
        /// <param name="i_VehicleToPrint"></param>
        public static void PrintFullDetails(VehicleRecord i_Record)
        {
            string basicVehicleView = GetGeneralVehicleView(i_Record.m_Vehicle);
            string ownerView = VehicleOwnerView.GetVehicleOwnerView(i_Record);
            string tiresView = TiresView.GetTiresView(i_Record.m_Vehicle.m_Tires);
            string powerSourceView = GetPowerSourceView(i_Record.m_Vehicle.r_PowerSource);
            string vehicleSpecificView = GetSpecificVehicleView(i_Record.m_Vehicle);

            Console.WriteLine(
                string.Format(
                    GarageSystemText.k_VehicleViewTemplate,
                    basicVehicleView,
                    ownerView,
                    tiresView,
                    powerSourceView,
                    vehicleSpecificView));
        }

        /// <summary>
        /// Print :
        /// license name
        /// model name
        /// </summary>
        /// <param name="i_Vehicle"></param>
        private static string GetGeneralVehicleView(Vehicle i_Vehicle)
        {
            return string.Format(
                GarageSystemText.k_FullDetailsTemplate,
                i_Vehicle.r_LicenseNumber,
                i_Vehicle.r_ModelName);
        }

        /// <summary>
        /// Get relevant power source view
        /// </summary>
        /// <param name="i_PowerSource"></param>
        /// <returns></returns>
        private static string GetPowerSourceView(PowerSource i_PowerSource)
        {
            string result = string.Empty;
            if (i_PowerSource.GetType() == typeof(ElectricPowerSource))
            {
                result = ElectricPowerSourceView.GetElectricPowerSourceView(i_PowerSource as ElectricPowerSource);
            }
            else if (i_PowerSource.GetType() == typeof(PetrolPowerSource))
            {
                result = PetrolPowerSourceView.GetPetrolPowerSourceView(i_PowerSource as PetrolPowerSource);
            }

            return result;
        }

        /// <summary>
        /// Get vehicle specific detail view
        /// </summary>
        /// <param name="i_VehicleToPrint"></param>
        private static string GetSpecificVehicleView(Vehicle i_VehicleToPrint)
        {
            string result = string.Empty;
            Type typeOfVehicle = i_VehicleToPrint.GetType();
            if (typeOfVehicle.IsSubclassOf(typeof(Motorcycle)))
            {
                result = MotorcycleView.GetMotorCycleView(i_VehicleToPrint as Motorcycle);
            }
            else if (typeOfVehicle.IsSubclassOf(typeof(Car)))
            {
                result = CarView.GetCarView(i_VehicleToPrint as Car);
            }
            else if (typeOfVehicle == typeof(Truck))
            {
                result = TruckView.GetTruckView(i_VehicleToPrint as Truck);
            }

            return result;
        }

        public static void PrintGetLicenseNumberMessage()
        {
            Console.Write(GarageSystemText.k_VehicleGetLicenseNumberMessage);
        }

        public static void PrintGetVehicleModelNameMessage()
        {
            Console.Write(GarageSystemText.k_VehicleGetVehicleModelNameMessage);
        }

        public static void PrintGetTiresManufacturerNameMessage()
        {
            Console.Write(GarageSystemText.k_VehicleGetTiresManufacturerNameMessage);
        }
    }
}
