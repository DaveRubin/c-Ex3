using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        public ElectricPowerSource PowerSource
        {
            get
            {
                return r_PowerSource as ElectricPowerSource;
            }
        }

        public ElectricCar(
            float i_maxHours,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            eCarColor i_color,
            int i_doorsCount)
            : base(new ElectricPowerSource(i_maxHours), i_modelName, i_licenseNumber, i_wheels, i_color, i_doorsCount)
        {

        }

    }
}
