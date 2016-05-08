using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class Vehicle
    {
        public readonly PowerSource r_powerSource;
        public readonly string r_modelName;
        public readonly string r_licenseNumber;

        public List<Wheel> m_wheels;

        public float GetSourceEnergyPercentage
        {
            get
            {
                return r_powerSource.GetPercentageLeft;
            }
        }

        public Vehicle(PowerSource i_powerSource, string i_modelName, string i_licenseNumber, List<Wheel> i_wheels)
        {
            r_powerSource = i_powerSource;
            r_modelName = i_modelName;
            r_licenseNumber = i_licenseNumber;
            m_wheels = i_wheels;
        }
    }
}
