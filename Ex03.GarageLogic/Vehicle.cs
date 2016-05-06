using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class Vehicle
    {
        private PowerSource m_powerSource;
        private string m_modelName;
        private string m_licenseNumber;
        private List<Wheel> m_wheels;

        public float GetSourceEnergyPercentage
        {
            get
            {
                return m_powerSource.GetPercentageLeft;
            }
        }

        public Vehicle()
        {
            
        }
    }
}
