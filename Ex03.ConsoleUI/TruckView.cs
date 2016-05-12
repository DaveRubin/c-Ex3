﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class TruckView
    {

        public static string GetTruckView(Truck i_Truck)
        {
            return string.Format(
                VehicleViewTextTemplates.k_TruckViewTemplate,
                i_Truck.r_IsCarryingHazardousMaterials,
                i_Truck.r_MaxWeightAllowed);
        }
    }
}
