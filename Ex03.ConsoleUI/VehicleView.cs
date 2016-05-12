using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class VehicleView
    {

        /// <summary>
        /// Print full details of a vehicle
        /// </summary>
        /// <param name="i_VehicleToPrint"></param>
        public static void PrintFullDetails(VehicleRecord i_record)
        {
            string basicVehicleView = GeneralVehicleView.GetGeneralVehicleView(i_record.m_Vehicle);
            string ownerView = CarOwnerView.GetVehicleOwnerView(i_record);
            string tiresView = TiresView.GetTiresView(i_record.m_Vehicle.m_Tires);
            string powerSourceView = GetPowerSourceView(i_record.m_Vehicle.r_PowerSource);
            string vehicleSpecificView = GetSpecificVehicleView(i_record.m_Vehicle);

            Console.WriteLine(
                string.Format(
                    VehicleViewTextTemplates.k_VehicleViewTemplate,
                    basicVehicleView,
                    ownerView,
                    tiresView,
                    powerSourceView,
                    vehicleSpecificView));

        }

        /// <summary>
        /// Get relevant power source view
        /// </summary>
        /// <param name="i_PowerSource"></param>
        /// <returns></returns>
        private static string GetPowerSourceView(PowerSource i_PowerSource)
        {
            string result = "";
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
            string result = "";
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

    }
}
