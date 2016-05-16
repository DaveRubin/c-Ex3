﻿using System;

namespace Ex03.GarageLogic
{
    public class Tire
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

        public Tire(string i_manufacturerName, float i_maxAirPressure)
        {
            if (i_maxAirPressure <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_TireNonPositiveMaxAirPressure, "i_maxAirPressure");
            }

            r_ManufacturerName = i_manufacturerName;
            r_MaxAirPressure = i_maxAirPressure;
            m_CurrentAirPressure = i_maxAirPressure;
        }

        public void Inflate(float i_airAddition)
        {
            if (m_CurrentAirPressure + i_airAddition > r_MaxAirPressure)
            {
                throw new ValueOutOfRangeException(
                    ExceptionMessages.k_TireExceededMaxAirPressure,
                    0,
                    (int)r_MaxAirPressure);
            }

            m_CurrentAirPressure += i_airAddition;
        }

        public void InflateToMax()
        {
            m_CurrentAirPressure = r_MaxAirPressure;
        }
    }
}
