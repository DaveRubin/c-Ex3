using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class TruckView
    {
        private static string k_TruckViewTemplate = @"Carrying hazardous materials : {0}
Weight limit: {1}";

        public static string GetTruckView(Truck i_Truck)
        {
            return string.Format(k_TruckViewTemplate, i_Truck.r_IsCarryingHazardousMaterials, i_Truck.r_MaxWeightAllowed);
        }
    }
}
