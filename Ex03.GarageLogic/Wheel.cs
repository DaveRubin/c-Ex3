using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Wheel
    {
        public readonly string r_manufacturerName;
        public readonly float r_maxAirPressure;
        private float m_currentAirPressure;

        public float CurrentAirPressure 
        {
            get
            {
                return m_currentAirPressure;
            }
        }

        public Wheel(string i_manufacturerName,float i_maxAirPressure)
        {
            r_manufacturerName = i_manufacturerName;
            r_maxAirPressure = i_maxAirPressure;
            m_currentAirPressure = i_maxAirPressure;
        }

        public void Inflate(float i_airAddition)
        {
            if (m_currentAirPressure + i_airAddition > r_maxAirPressure)
            {
                //TODO: check max exception
            }
            m_currentAirPressure += i_airAddition;
        }
    }
}
