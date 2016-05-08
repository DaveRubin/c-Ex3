using System;
using System.Collections.Generic;
using System.Text;

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
            float i_maxHours,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            eLicenseType i_licenseType,
            int i_engineVolume)
            : base(new ElectricPowerSource(i_maxHours), i_modelName, i_licenseNumber, i_wheels,i_licenseType,i_engineVolume)
        {
            
        }
    }
}
