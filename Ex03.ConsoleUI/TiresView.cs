using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class TiresView
    {
        //4 should be TAB
        private const string k_TirePairTemplate = @"{0,-20} {1}
";
        private const string k_AirPressureTemplate = "{0}/{1}";


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
                    string.Format(k_TirePairTemplate, "Manufacturer", "Air pressure"));
            result.Append(
                    string.Format(k_TirePairTemplate, "------------", "------------"));

            //devide tires to pairs and print 
            for (int i = 0; i < i_Tires.Count ; i++)
            {
                Tire tire = i_Tires[i];
                string manufacturerName = tire.r_ManufacturerName;
                string airPressure = string.Format(k_AirPressureTemplate, tire.CurrentAirPressure, tire.r_MaxAirPressure);

                result.Append(
                    string.Format(k_TirePairTemplate, manufacturerName, airPressure));
            }

            return result.ToString();
        }
    }
}
