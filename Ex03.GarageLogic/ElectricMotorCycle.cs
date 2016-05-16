using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class ElectricMotorCycle : Motorcycle
    {
        public ElectricPowerSource PowerSource
        {
            get
            {
                return r_PowerSource as ElectricPowerSource;
            }
        }

        public ElectricMotorCycle(
            float i_MaxHours,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            eLicenseType i_LicenseType,
            int i_EngineVolume)
            : base(
                new ElectricPowerSource(i_MaxHours),
                i_ModelName,
                i_LicenseNumber,
                i_Tires,
                i_LicenseType,
                i_EngineVolume)
        {
        }
    }
}
