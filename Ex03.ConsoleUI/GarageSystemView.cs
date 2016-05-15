using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    internal class GarageSystemView
    {
        public static void ShowScreen(string i_screenString)
        {
            PrintSystemHeader();
            Console.WriteLine(string.Format(i_screenString));
        }

        public static GarageLogic.VehicleRecord RequestVehicleRecordByLicensePlateNumber()
        {
            GarageLogic.VehicleRecord result = null;
            PrintSystemHeader();
            Console.WriteLine(string.Format(GarageSystemText.k_RequestLicensePlateNumber));
            string userInput = Console.ReadLine();
            if (GarageLogic.Garage.IsVehicleExist(userInput))
            {
                result = GarageLogic.Garage.GetRecordByPlateNumber(userInput);
            }
            else
            {
                Console.WriteLine("Record was not found, press 'q' to main menue or press any other key to continue:");
                char userInputAfterError = Console.ReadKey().KeyChar;
                if (!userInputAfterError.Equals('q'))
                {
                    RequestVehicleRecordByLicensePlateNumber();
                }
            }
            return result;
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

        public static void PrintStatusChangedAfterInsertionMessage()
        {
            Console.WriteLine(GarageSystemText.k_StatusChangedAfterInsertionMessage);
        }

        public static void PrintRecordAddedSuccessfulyMessage()
        {
            Console.WriteLine(GarageSystemText.k_StatusChangedAfterInsertionMessage);
        }

        public static void PrintVehicleRecordSelectVehicleTypeMessage()
        {
            Console.WriteLine(GarageSystemText.k_VehicleRecordSelectVehicleTypeMessage);
        }
    }
}
