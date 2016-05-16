using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class PetrolCar : Car
    {
        public PetrolPowerSource PowerSource
        {
            get
            {
                return r_PowerSource as PetrolPowerSource;
            }
        }

        public PetrolCar(
            PetrolPowerSource.eFuelType i_FuelType,
            float i_MaxFuelAllowed,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            eCarColor i_Color,
            int i_DoorsCount)
            : base(
                new PetrolPowerSource(i_FuelType, i_MaxFuelAllowed),
                i_ModelName,
                i_LicenseNumber,
                i_Tires,
                i_Color,
                i_DoorsCount)
        {
        }
    }
}
