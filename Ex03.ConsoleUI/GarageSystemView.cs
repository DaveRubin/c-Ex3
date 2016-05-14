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

        public static GarageLogic.Garage.eVehicleStatus RequestStatusFromUser()
        {
            GarageLogic.Garage.eVehicleStatus result = GarageLogic.Garage.eVehicleStatus.BeingFixed;
            PrintSystemHeader();
            Console.WriteLine(string.Format(GarageSystemText.k_VehicleStatusViewRequest));
            foreach (string status in Enum.GetNames(typeof(GarageLogic.Garage.eVehicleStatus)))
            {
                Console.WriteLine(status);
            }
            string userInput = Console.ReadLine();
            try
            {
                GarageLogic.Garage.eVehicleStatus statusSelected = (GarageLogic.Garage.eVehicleStatus)Enum.Parse(
                typeof(GarageLogic.Garage.eVehicleStatus), userInput);
                result = statusSelected;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                PauseForKeyStroke();
                RequestStatusFromUser();
            }            
            return result;
        }

        public static void PauseForKeyStroke()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_PressAnyKeyToContinue));
            Console.ReadKey();
        }

        public static void PromptResultsDisplay()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_PromptResultDisplay));
        }

    }
}
