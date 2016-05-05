using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Wheel
    {
        private string m_manufacturerName;
        private float m_currentAirPressure;
        private float m_maxAirPressure;

        public Wheel()
        {
            
        }

        public void Inflate(float i_airAddition)
        {
            //TODO: check max exception
            m_currentAirPressure += i_airAddition;
        }
    }
}
