using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class MotorcycleView
    {

        public static string GetMotorCycleView(Motorcycle i_Motorcycle)
        {
            return string.Format(
                VehicleViewTextTemplates.k_MotorcycleViewTemplate,
                i_Motorcycle.r_LicenseType,
                i_Motorcycle.r_EngineVolume);
        }
    }
}
