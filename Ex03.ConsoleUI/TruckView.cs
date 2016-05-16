using System;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class TruckView
    {
        public static string GetTruckView(Truck i_Truck)
        {
            return string.Format(
                GarageSystemText.k_TruckViewTemplate,
                i_Truck.r_IsCarryingHazardousMaterials,
                i_Truck.r_MaxWeightAllowed);
        }

        public static void PrintEnterIsHazMatMessage(char i_TrueChar, char i_FalseChar)
        {
            Console.WriteLine(GarageSystemText.k_TruckEnterIsHazMatMessageTemplate, i_TrueChar, i_FalseChar);
        }

        public static void PrintEnterMaxWeightMessage()
        {
            Console.WriteLine(GarageSystemText.k_TruckEnterMaxWeightMessage);
        }
    }
}
