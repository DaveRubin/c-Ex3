using System;
using System.Collections.Generic;
using System.Text;

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
        /// <param name="i_maxHours"></param>
        public ElectricPowerSource(float i_maxHours)
        {
            if (i_maxHours <= 0)
            {
                throw new ValueOutOfRangeException(ExceptionMessages.k_ElectricPowerSourceNonPositiveMaxHours);
            }

            r_MaxHours = i_maxHours;
            m_HoursLeft = i_maxHours;
        }

        /// <summary>
        /// Charge electric power source
        /// (shoulsn't exceed max hours)
        /// </summary>
        /// <param name="i_hoursToCharge"></param>
        public void Charge(float i_hoursToCharge)
        {
            if (m_HoursLeft+ i_hoursToCharge > r_MaxHours)
            {
                throw new ValueOutOfRangeException(ExceptionMessages.k_ElectricPowerSourceExceedingMaximumHours);
            }

            m_HoursLeft += i_hoursToCharge;
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
