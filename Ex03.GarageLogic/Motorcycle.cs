using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Motorcycle : Vehicle
    {
        public readonly eLicenseType r_LicenseType;
        public readonly int r_EngineVolume;

        /// <summary>
        /// Create a new motorcycle
        /// </summary>
        /// <param name="i_PowerSource"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        /// <param name="i_Tires"></param>
        /// <param name="i_LicenseType"></param>
        /// <param name="i_EngineVolume"></param>
        protected Motorcycle(
            PowerSource i_PowerSource,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            eLicenseType i_LicenseType,
            int i_EngineVolume)
            : base(i_PowerSource, i_ModelName, i_LicenseNumber, i_Tires)
        {
            if (i_EngineVolume <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_MotorcycleNonPositiveEngineVolumeValue, "i_EngineVolume");
            }

            r_LicenseType = i_LicenseType;
            r_EngineVolume = i_EngineVolume;
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
