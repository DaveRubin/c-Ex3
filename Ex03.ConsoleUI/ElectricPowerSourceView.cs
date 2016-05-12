using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class ElectricPowerSourceView
    {
        private const string k_ElectricPowerSourceViewTemplate = @"Hours Left : {0}/{1}";

        public static string GetElectricPowerSourceView(ElectricPowerSource i_PowerSource)
        {
            return string.Format(k_ElectricPowerSourceViewTemplate,i_PowerSource.HoursLeft,i_PowerSource.r_MaxHours);
        }
    }
}
