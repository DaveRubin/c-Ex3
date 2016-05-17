using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        public readonly PowerSource r_PowerSource;
        public readonly string r_ModelName;
        public readonly string r_LicenseNumber;
        public List<Tire> m_Tires;

        public int GetSourceEnergyPercentage
        {
            get
            {
                return r_PowerSource.GetPercentageLeft;
            }
        }

        protected Vehicle(PowerSource i_PowerSource, string i_ModelName, string i_LicenseNumber, List<Tire> i_Tires)
        {
            r_PowerSource = i_PowerSource;
            r_ModelName = i_ModelName;
            r_LicenseNumber = i_LicenseNumber;
            m_Tires = i_Tires;
        }
    }
}
