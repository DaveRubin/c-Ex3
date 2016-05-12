using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class VehicleView
    {

        private const string k_VehicleViewTemplate = @"----------------------------------
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
----------------------------------";

        /// <summary>
        /// Print full details of a vehicle
        /// </summary>
        /// <param name="i_VehicleToPrint"></param>
        public static void PrintFullDetails(VehicleRecord i_record)
        {
            string basicVehicleView = GeneralVehicleView.GetGeneralVehicleView(i_record.m_Vehicle);
            string ownerView = CarOwnerView.GetVehicleOwnerView(i_record);
            string tiresView = "";
            string powerSourceView = "";
            string vehicleSpecificView = GetSpecificVehicleView(i_record.m_Vehicle);

            Console.WriteLine(string.Format(k_VehicleViewTemplate,basicVehicleView,ownerView,tiresView,powerSourceView,vehicleSpecificView));

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
