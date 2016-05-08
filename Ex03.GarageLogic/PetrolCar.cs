using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class PetrolCar : Car
    {
        PetrolPowerSource PowerSource
        {
            get
            {
                return r_PowerSource as PetrolPowerSource;
            }
        }

        public PetrolCar(
            PetrolPowerSource.eFuelType i_fuelType,
            float i_maxFuelAllowed,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            eCarColor i_color,
            int i_doorsCount)
            : base(
                new PetrolPowerSource(i_fuelType, i_maxFuelAllowed),
                i_modelName,
                i_licenseNumber,
                i_wheels,
                i_color,
                i_doorsCount)
        {
        }
    }
}
