using System.Collections.Generic;

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
            float i_MaxHours,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            eCarColor i_Color,
            int i_DoorsCount)
            : base(new ElectricPowerSource(i_MaxHours), i_ModelName, i_LicenseNumber, i_Tires, i_Color, i_DoorsCount)
        {
        }
    }
}
