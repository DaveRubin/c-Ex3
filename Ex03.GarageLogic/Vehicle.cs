using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public  class Vehicle
    {
        public readonly PowerSource r_PowerSource;
        public readonly string r_ModelName;
        public readonly string r_LicenseNumber;

        public List<Tire> m_Tires;

        public float GetSourceEnergyPercentage
        {
            get
            {
                return r_PowerSource.GetPercentageLeft;
            }
        }

        public Vehicle(PowerSource i_powerSource, string i_modelName, string i_licenseNumber, List<Tire> i_Tires)
        {
            r_PowerSource = i_powerSource;
            r_ModelName = i_modelName;
            r_LicenseNumber = i_licenseNumber;
            m_Tires = i_Tires;
        }
    }
}
