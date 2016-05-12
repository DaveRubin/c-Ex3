using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class GeneralVehicleView
    {

        /// <summary>
        /// Print :
        /// license name
        /// model name
        /// </summary>
        /// <param name="i_Vehicle"></param>
        public static string GetGeneralVehicleView(Vehicle i_Vehicle)
        {
            return string.Format(
                VehicleViewTextTemplates.k_FullDetailsTemplate,
                i_Vehicle.r_LicenseNumber,
                i_Vehicle.r_ModelName);
        }
    }
}
