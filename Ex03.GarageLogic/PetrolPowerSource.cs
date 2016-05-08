using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class PetrolPowerSource : PowerSource
    {
        public readonly eFuelType r_feulType;
        public readonly float r_maxFuelAllowed;
        private float m_currentFuelAmount;

        public float CurrentFuelAmount
        {
            get
            {
                return m_currentFuelAmount;
            }
        }

        public PetrolPowerSource(eFuelType i_fuelType, float i_maxFuelAllowed)
        {
            r_feulType = i_fuelType;
            r_maxFuelAllowed = i_maxFuelAllowed;
            m_currentFuelAmount = i_maxFuelAllowed;
        }

        public void Fuel(eFuelType i_fuelType, float i_amount)
        {
            if (i_fuelType != r_feulType)
            {
                //TODO : throw exception
            }
            else if (i_amount + m_currentFuelAmount > r_maxFuelAllowed)
            {
                //TODO: throw another exception
            }
            m_currentFuelAmount += i_amount;
        }

        public override float GetPercentageLeft
        {
            get
            {
                return m_currentFuelAmount / r_maxFuelAllowed;
            }
        }

        public enum eFuelType 
        {
            Diesel,
            Octan96,
            Octan95,
            Octan98
        }
    }
}
