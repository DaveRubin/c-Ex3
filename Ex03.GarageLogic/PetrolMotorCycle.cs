using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class PetrolMotorCycle : Motorcycle
    {
        public PetrolPowerSource PowerSource
        {
            get
            {
                return r_PowerSource as PetrolPowerSource;
            }
        }

        public PetrolMotorCycle(
            PetrolPowerSource.eFuelType i_fuelType,
            float i_maxFuelAllowed,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            eLicenseType i_licenseType,
            int i_engineVolume)
            : base(
                new PetrolPowerSource(i_fuelType, i_maxFuelAllowed),
                i_modelName,
                i_licenseNumber,
                i_wheels,
                i_licenseType,
                i_engineVolume)
        {
        }
    }
}
