using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        public readonly bool r_IsCarryingHazardousMaterials;
        public readonly float r_MaxWeightAllowed;

        public PetrolPowerSource PowerSource
        {
            get
            {
                return r_PowerSource as PetrolPowerSource;
            }
        }

        /// <summary>
        /// Create a new truck
        /// </summary>
        /// <param name="i_powerSource"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_wheels"></param>
        /// <param name="i_isCarryingHazardousMaterials"></param>
        /// <param name="i_maxWeightAllowed"></param>
        public Truck(
            PetrolPowerSource.eFuelType i_fuelType,
            float i_maxFuelAllowed,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            bool i_isCarryingHazardousMaterials,
            float i_maxWeightAllowed)
            : base(new PetrolPowerSource(i_fuelType, i_maxFuelAllowed), i_modelName, i_licenseNumber, i_wheels)
        {
            if (i_maxWeightAllowed <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_TruckNonPositiveWeight, "i_maxWeightAllowed");
            }

            r_IsCarryingHazardousMaterials = i_isCarryingHazardousMaterials;
            r_MaxWeightAllowed = i_maxWeightAllowed;
        }
    }
}
