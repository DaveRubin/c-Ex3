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

        public ElectricPowerSource(float i_maxHours)
        {
            r_maxHours = i_maxHours;
            m_hoursLeft = i_maxHours;
        }

        public void Charge(float i_hoursToCharge)
        {
            if (m_hoursLeft+ i_hoursToCharge > r_maxHours)
            {
                //TODO: throw exception
            }
            m_hoursLeft += i_hoursToCharge;
        }

        public override float GetPercentageLeft
        {
            get
            {
                return m_hoursLeft / r_maxHours;
            }
        }


    }
}
