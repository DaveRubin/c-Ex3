using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class ElectricPowerSourceView
    {
        public static string GetElectricPowerSourceView(ElectricPowerSource i_PowerSource)
        {
            return string.Format(
                VehicleViewTextTemplates.k_ElectricPowerSourceViewTemplate,
                i_PowerSource.HoursLeft,
                i_PowerSource.r_MaxHours);
        }
    }
}
