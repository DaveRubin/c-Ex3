using System;

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

        public Tire(string i_ManufacturerName, float i_MaxAirPressure)
        {
            if (i_MaxAirPressure <= 0)
            {
                throw new ArgumentException(ExceptionMessages.k_TireNonPositiveMaxAirPressure, "i_MaxAirPressure");
            }

            r_ManufacturerName = i_ManufacturerName;
            r_MaxAirPressure = i_MaxAirPressure;
            m_CurrentAirPressure = i_MaxAirPressure;
        }

        public void Inflate(float i_AirAddition)
        {
            if (m_CurrentAirPressure + i_AirAddition > r_MaxAirPressure)
            {
                throw new ValueOutOfRangeException(
                    ExceptionMessages.k_TireExceededMaxAirPressure,
                    0,
                    (int)r_MaxAirPressure);
            }

            m_CurrentAirPressure += i_AirAddition;
        }

        public void InflateToMax()
        {
            m_CurrentAirPressure = r_MaxAirPressure;
        }
    }
}
