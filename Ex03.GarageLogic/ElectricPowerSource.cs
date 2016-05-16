using System;

namespace Ex03.GarageLogic
{
    public class ElectricPowerSource : PowerSource
    {
        public readonly float r_MaxHours;
        private float m_HoursLeft;

        public float HoursLeft
        {
            get
            {
                return m_HoursLeft;
            }
        }

        /// <summary>
        /// Constructor for electric power source
        /// </summary>
        /// <param name="i_MaxHours"></param>
        public ElectricPowerSource(float i_MaxHours)
        {
            if (i_MaxHours <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_ElectricPowerSourceNonPositiveMaxHours, "i_MaxHours");
            }

            r_MaxHours = i_MaxHours;
            m_HoursLeft = i_MaxHours;
        }

        /// <summary>
        /// Charge electric power source
        /// (shoulsn't exceed max hours)
        /// </summary>
        /// <param name="i_HoursToCharge"></param>
        public void Charge(float i_HoursToCharge)
        {
            if (m_HoursLeft + i_HoursToCharge > r_MaxHours)
            {
                throw new ValueOutOfRangeException(
                    ExceptionMessages.k_ElectricPowerSourceExceedingMaximumHours,
                    0,
                    (int)r_MaxHours);
            }

            m_HoursLeft += i_HoursToCharge;
        }

        /// <summary>
        /// Get power left (0-1)
        /// </summary>
        public override float GetPercentageLeft
        {
            get
            {
                return m_HoursLeft / r_MaxHours;
            }
        }
    }
}
