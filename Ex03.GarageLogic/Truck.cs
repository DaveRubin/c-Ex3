using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        public readonly bool r_IsCarryingHazardousMaterials;
        public readonly float r_MaxWeightAllowed ;

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
            PowerSource i_powerSource,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            bool i_isCarryingHazardousMaterials,
            float i_maxWeightAllowed
            )
            : base(i_powerSource, i_modelName, i_licenseNumber, i_wheels)
        {
            r_IsCarryingHazardousMaterials = i_isCarryingHazardousMaterials;
            r_MaxWeightAllowed = i_maxWeightAllowed;
        }

    }
}
