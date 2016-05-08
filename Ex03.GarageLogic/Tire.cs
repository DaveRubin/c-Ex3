using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Tire
    {
        public readonly string r_ManufacturerName;
        public readonly float r_MaxAirPressure;
        private float m_CurrentAirPressure;

        public float CurrentAirPressure 
        {
            get
            {
                return m_CurrentAirPressure;
            }
        }

        public Tire(string i_manufacturerName,float i_maxAirPressure)
        {
            r_ManufacturerName = i_manufacturerName;
            r_MaxAirPressure = i_maxAirPressure;
            m_CurrentAirPressure = i_maxAirPressure;
        }

        public void Inflate(float i_airAddition)
        {
            if (m_CurrentAirPressure + i_airAddition > r_MaxAirPressure)
            {
                //TODO: check max exception
            }
            m_CurrentAirPressure += i_airAddition;
        }

        public void InflateToMax()
        {
            m_CurrentAirPressure = r_MaxAirPressure;
        }
    }
}
