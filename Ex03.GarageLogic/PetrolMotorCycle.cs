using System.Collections.Generic;

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
            PetrolPowerSource.eFuelType i_FuelType,
            float i_MaxFuelAllowed,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            eLicenseType i_LicenseType,
            int i_EngineVolume)
            : base(
                new PetrolPowerSource(i_FuelType, i_MaxFuelAllowed),
                i_ModelName,
                i_LicenseNumber,
                i_Tires,
                i_LicenseType,
                i_EngineVolume)
        {
        }
    }
}
