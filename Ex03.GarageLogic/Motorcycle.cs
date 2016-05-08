using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicle
    {
        public readonly eLicenseType r_LicenseType;
        public readonly int r_EngineVolume;

        /// <summary>
        /// Create a new motorcycle
        /// </summary>
        /// <param name="i_powerSource"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_wheels"></param>
        /// <param name="i_licenseType"></param>
        /// <param name="i_engineVolume"></param>
        public Motorcycle(
            PowerSource i_powerSource,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            eLicenseType i_licenseType,
            int i_engineVolume)
            : base(i_powerSource, i_modelName, i_licenseNumber, i_wheels)
        {
            r_LicenseType = i_licenseType;
            r_EngineVolume = i_engineVolume;
        }

        public enum eLicenseType
        {
            A, 
            A1, 
            AB, 
            B1 
        }
    }
}
