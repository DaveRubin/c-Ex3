using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        public readonly bool r_isCarryingHazardousMaterials;
        public readonly float r_maxWeightAllowed ;

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
            List<Wheel> i_wheels,
            bool i_isCarryingHazardousMaterials,
            float i_maxWeightAllowed
            )
            : base(i_powerSource, i_modelName, i_licenseNumber, i_wheels)
        {
            r_isCarryingHazardousMaterials = i_isCarryingHazardousMaterials;
            r_maxWeightAllowed = i_maxWeightAllowed;
        }

    }
}
