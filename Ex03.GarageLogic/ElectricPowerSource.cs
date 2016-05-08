using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ElectricPowerSource : PowerSource
    {

        public readonly float r_maxHours;
        private float m_hoursLeft;

        public float HoursLeft
        {
            get
            {
                return m_hoursLeft;
            }
        }

        /// <summary>
        /// Constructor for electric power source
        /// </summary>
        /// <param name="i_maxHours"></param>
        public ElectricPowerSource(float i_maxHours)
        {
            r_maxHours = i_maxHours;
            m_hoursLeft = i_maxHours;
        }

        /// <summary>
        /// Charge electric power source
        /// (shoulsn't exceed max hours)
        /// </summary>
        /// <param name="i_hoursToCharge"></param>
        public void Charge(float i_hoursToCharge)
        {
            if (m_hoursLeft+ i_hoursToCharge > r_maxHours)
            {
                //TODO: throw exception
            }
            m_hoursLeft += i_hoursToCharge;
        }

        /// <summary>
        /// Get power left (0-1)
        /// </summary>
        public override float GetPercentageLeft
        {
            get
            {
                return m_hoursLeft / r_maxHours;
            }
        }


    }
}
