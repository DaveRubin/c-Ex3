using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleFactory
    {
        /// <summary>
        /// Create a new electric motorcycle
        /// </summary>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_licencType"></param>
        /// <param name="i_engineVolume"></param>
        /// <returns></returns>
        public static Motorcycle CreateElectricMotorcycle(
            string i_modelName,
            string i_licenseNumber,
            Motorcycle.eLicenseType i_licencType,
            int i_engineVolume)
        {
            Motorcycle result;
            int numOfTires = 2;

            //TODO: create consts for tires default
            //TODO: create air pressures consts
            //TODO: create enum for manufacturers
            List<Tire> tires = GetTires(numOfTires, "Good Year", 40);
            ElectricPowerSource powerSource = new ElectricPowerSource(130);
            result = new Motorcycle(powerSource, i_modelName, i_licenseNumber, tires, i_licencType, i_engineVolume);
            return result;
        }

        /// <summary>
        /// Create a set of tires
        /// </summary>
        /// <param name="i_numOfTires"></param>
        /// <param name="i_manufacturerName"></param>
        /// <param name="i_airPressure"></param>
        /// <returns></returns>
        private static List<Tire> GetTires(int i_numOfTires, string i_manufacturerName, int i_airPressure)
        {
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < i_numOfTires; i++)
            {
                Tire tire = new Tire(i_manufacturerName, i_airPressure); 
                tires.Add(tire);
            }
            return tires;
        }
    }
}
