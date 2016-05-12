using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class PetrolPowerSourceView
    {
        private const string k_PetrolPowerSourceViewTemplate = @"Fuel left : {0}/{1}
Fuel type: {2}";

        public static string GetPetrolPowerSourceView(PetrolPowerSource i_PowerSource)
        {
            return string.Format(
                k_PetrolPowerSourceViewTemplate,
                i_PowerSource.CurrentFuelAmount,
                i_PowerSource.r_MaxFuelAllowed,
                i_PowerSource.r_FeulType);
        }
    }
}
