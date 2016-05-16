using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class TiresView
    {
        /// <summary>
        /// Create a two column string for tire manufacturer and tire air pressure
        /// </summary>
        /// <param name="i_Tires"></param>
        /// <returns></returns>
        public static string GetTiresView(List<Tire> i_Tires)
        {
            StringBuilder result = new StringBuilder();
            //Append header
            result.Append(
                string.Format(
                    GarageSystemText.k_TirePairTemplate,
                    GarageSystemText.k_TireManufecturerHeaderText,
                    GarageSystemText.k_TireAirPressureHeaderText));
            result.Append(
                string.Format(
                    GarageSystemText.k_TirePairTemplate,
                    GarageSystemText.k_TireColumnUnderlineText,
                    GarageSystemText.k_TireColumnUnderlineText));

            //devide tires to pairs and print 
            for (int i = 0; i < i_Tires.Count ; i++)
            {
                Tire tire = i_Tires[i];
                string manufacturerName = tire.r_ManufacturerName;
                string airPressure = string.Format(
                    GarageSystemText.k_TireAirPressureTemplate,
                    tire.CurrentAirPressure,
                    tire.r_MaxAirPressure);

                result.Append(string.Format(GarageSystemText.k_TirePairTemplate, manufacturerName, airPressure));
            }

            return result.ToString();
        }
    }
}
