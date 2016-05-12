using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    internal class GarageSystemView
    {
        public static void ShowWelcomeScreen()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_WelcomeScreen));
            Console.ReadKey();
        }

        public static void ShowMenueScreen()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_Menue));
        }

        public static void ShowVehiclesByLicenseScreen()
        {

        }

        public static void ShowNewVehicleScreen()
        {

        }

        public static void ShowStatusChangeScreen()
        {

        }

        public static void ShowRefuelScreen()
        {

        }
        
        public static void ShowRechargeScreen()
        {

        }

        public static void ShowVehicelDetailsScren()
        {

        }

    }
}
