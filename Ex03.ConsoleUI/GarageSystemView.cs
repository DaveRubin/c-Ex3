using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    internal class GarageSystemView
    {
        public static void ShowWelcomeScreen()
        {
            PrintSystemHeader();
            Console.WriteLine(string.Format(GarageSystemText.k_WelcomeScreen));
            Console.ReadKey();
        }

        public static void ShowMenueScreen()
        {
            PrintSystemHeader();
            Console.WriteLine(string.Format(GarageSystemText.k_Menue));
        }

        public static void ShowNewVehicleScreen()
        {
            
        }

        public static void ShowVehiclesByStatusScreen()
        {

        }

        public static void ShowStatusChangeScreen()
        {

        }

        public static void ShowInflateVehicleScreen()
        {

        }

        public static void ShowRefuelScreen()
        {

        }
        
        public static void ShowRechargeScreen()
        {

        }

        public static void ShowVehicelDetailsScreen()
        {

        }

        public static void RequsetPhoneNumber()
        {
            PrintSystemHeader();
            Console.WriteLine(string.Format(GarageSystemText.k_RequestPhoneNumber));
        }

        public static void RequestLicensePlateNumber()
        {
            PrintSystemHeader();
            Console.WriteLine(string.Format(GarageSystemText.k_RequestLicensePlateNumber));
        }

        public static void PrintSystemHeader()
        {
            Console.Clear();
            Console.WriteLine(string.Format(GarageSystemText.k_SystemScreenHeader));
        }

    }
}
