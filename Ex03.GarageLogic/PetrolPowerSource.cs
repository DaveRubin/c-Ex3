using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class PetrolPowerSource : PowerSource
    {
        public readonly eFuelType r_FeulType;
        public readonly float r_MaxFuelAllowed;
        private float m_CurrentFuelAmount;

        public float CurrentFuelAmount
        {
            get
            {
                return m_CurrentFuelAmount;
            }
        }

        public PetrolPowerSource(eFuelType i_fuelType, float i_maxFuelAllowed)
        {
            r_FeulType = i_fuelType;
            r_MaxFuelAllowed = i_maxFuelAllowed;
            m_CurrentFuelAmount = i_maxFuelAllowed;
        }

        /// <summary>
        /// Fuel power source with petrol
        /// </summary>
        /// <param name="i_fuelType">should match power source fuel type</param>
        /// <param name="i_amount">should'nt excees r_maxFuelAllowed</param>
        public void Fuel(eFuelType i_fuelType, float i_amount)
        {
            if (i_fuelType != r_FeulType)
            {
                //TODO : throw exception
            }
            else if (i_amount + m_CurrentFuelAmount > r_MaxFuelAllowed)
            {
                //TODO: throw another exception
            }
            m_CurrentFuelAmount += i_amount;
        }

        /// <summary>
        /// Get Fuel left (0-1)
        /// </summary>
        public override float GetPercentageLeft
        {
            get
            {
                return m_CurrentFuelAmount / r_MaxFuelAllowed;
            }
        }

        public enum eFuelType 
        {
            Soler,
            Octan96,
            Octan95,
            Octan98
        }
    }
}
