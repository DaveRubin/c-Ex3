using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class GeneralVehicleView
    {
        private const string k_FullDetailsTemplate = @"License number: {0}
Model name: {1}";

        /// <summary>
        /// Print :
        /// license name
        /// model name
        /// </summary>
        /// <param name="i_Vehicle"></param>
        public static string GetGeneralVehicleView(Vehicle i_Vehicle)
        {
            return string.Format(
                k_FullDetailsTemplate,
                i_Vehicle.r_LicenseNumber,
                i_Vehicle.r_ModelName);
        }
    }
}
