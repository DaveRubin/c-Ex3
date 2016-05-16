using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class PetrolPowerSourceView
    {
        public static string GetPetrolPowerSourceView(PetrolPowerSource i_PowerSource)
        {
            return string.Format(
                GarageSystemText.k_PetrolPowerSourceViewTemplate,
                i_PowerSource.CurrentFuelAmount,
                i_PowerSource.r_MaxFuelAllowed,
                i_PowerSource.r_FeulType);
        }
    }
}
