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
        /// <param name="i_PowerSource"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        /// <param name="i_Tires"></param>
        /// <param name="i_IsCarryingHazardousMaterials"></param>
        /// <param name="i_MaxWeightAllowed"></param>
        public Truck(
            PetrolPowerSource.eFuelType i_FuelType,
            float i_MaxFuelAllowed,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            bool i_IsCarryingHazardousMaterials,
            float i_MaxWeightAllowed)
            : base(new PetrolPowerSource(i_FuelType, i_MaxFuelAllowed), i_ModelName, i_LicenseNumber, i_Tires)
        {
            if (i_MaxWeightAllowed <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_TruckNonPositiveWeight, "i_MaxWeightAllowed");
            }

            r_IsCarryingHazardousMaterials = i_IsCarryingHazardousMaterials;
            r_MaxWeightAllowed = i_MaxWeightAllowed;
        }
    }
}
