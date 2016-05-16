using System;

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

        public PetrolPowerSource(eFuelType i_FuelType, float i_MaxFuelAllowed)
        {
            if (i_MaxFuelAllowed <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_PetrolPowerSourceNonPositiveMaxFuel);
            }

            r_FeulType = i_FuelType;
            r_MaxFuelAllowed = i_MaxFuelAllowed;
            m_CurrentFuelAmount = i_MaxFuelAllowed;
        }

        /// <summary>
        /// Fuel power source with petrol
        /// </summary>
        /// <param name="i_FuelType">should match power source fuel type</param>
        /// <param name="i_Amount">should'nt excees r_maxFuelAllowed</param>
        public void Fuel(eFuelType i_FuelType, float i_Amount)
        {
            if (i_FuelType != r_FeulType)
            {
                throw new ArgumentException(ExceptionMessages.k_FuelTypeMismatch, "i_FuelType");
            }

            if (i_Amount + m_CurrentFuelAmount > r_MaxFuelAllowed)
            {
                throw new ValueOutOfRangeException(
                    ExceptionMessages.k_PetrolPowerSourceExceedingMaxFuelAllowed,
                    0,
                    (int)r_MaxFuelAllowed);
            }

            m_CurrentFuelAmount += i_Amount;
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
