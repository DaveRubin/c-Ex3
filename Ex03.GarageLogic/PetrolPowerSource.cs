using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class PetrolPowerSource : PowerSource
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
            if (i_maxFuelAllowed <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_PetrolPowerSourceNonPositiveMaxFuel);
            }

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
                throw new ArgumentException(ExceptionMessages.k_FuelTypeMismatch, "i_fuelType");
            }
            if (i_amount + m_CurrentFuelAmount > r_MaxFuelAllowed)
            {
                throw new ValueOutOfRangeException(ExceptionMessages.k_PetrolPowerSourceExceedingMaxFuelAllowed);
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
