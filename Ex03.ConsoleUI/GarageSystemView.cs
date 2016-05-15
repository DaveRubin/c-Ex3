using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{

    internal class GarageSystemView
    {
        public static void ShowScreen(string i_screenString)
        {
            PrintSystemHeader();
            Console.WriteLine(string.Format(i_screenString));
        }

        public static void PrintSystemHeader()
        {
            Console.Clear();
            Console.WriteLine(string.Format(GarageSystemText.k_SystemScreenHeader));
        }

        public static void PrintFilterByVehicleStatusMessage()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_VehicleStatusViewRequest));
            foreach (string status in Enum.GetNames(typeof(Garage.eVehicleStatus)))
            {
                Console.WriteLine(status);
            }
        }

        public static void PauseForKeyStroke()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_PressAnyKeyToContinue));
            Console.ReadKey();
        }

        public static void PromptResultsDisplay(List<string> mathcedEntries)
        {
            Console.WriteLine(string.Format(GarageSystemText.k_PromptResultDisplay));
            foreach (string plate in mathcedEntries)
            {
                Console.WriteLine(plate);
            }
        }

        public static void PrintRecordAddedSuccessfulyMessage()
        {
            Console.WriteLine(GarageSystemText.k_RecordAddedSuccessfulyMessage);
        }

        public static void PrintVehicleRecordSelectVehicleTypeMessage()
        {
            Console.WriteLine(GarageSystemText.k_VehicleRecordSelectVehicleTypeMessage);
        }

        public static void PrintStatusChangedSuccesfullyMessage(Garage.eVehicleStatus i_NewStatus)
        {
            Console.WriteLine(string.Format(GarageSystemText.k_StatusChangeSuccess, i_NewStatus));
        }

        public static void PrintExceptionMessage(string i_ExceptionMessage)
        {
            Console.WriteLine(i_ExceptionMessage);
        }

        public static void PrintRequestLicensePlateNumberMessage()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_RequestLicensePlateNumber));
        }

        public static void PrintTiresFilledSuccess(bool i_TiresFilledToMax)
        {
            if (i_TiresFilledToMax)
            {
                Console.WriteLine(string.Format(GarageSystemText.k_TiresHaveBeenInflatedToMax));
            }
            else
            {
                Console.WriteLine(string.Format(GarageSystemText.k_TiresHaveNotBeenInflatedToMax));
            }
        }

        public static void PrintRecordMatchCouldNotBeFount()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_RecordMatchCouldNotBeFound));
        }

        public static void PrintRequestRefuelTypeMessage()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_RequestFuleType));
        }

        public static void PrintRequestRefuelAmountMessage()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_RequestAmountToRefule));
        }

        public static void PrintRefuelOutcomeMessage(bool i_RefuelingSuccessfull)
        {
            if (i_RefuelingSuccessfull)
            {
                Console.WriteLine(string.Format(GarageSystemText.k_RefuelSuccess));
            }
            else
            {
                Console.WriteLine(string.Format(GarageSystemText.k_RefuelNoSuccess));
            }
        }

        public static void PrintRequestMinutesToChargeMessage()
        {
            Console.WriteLine(string.Format(GarageSystemText.k_RequestMinutessToRecharge));
        }

        public static void PrintRechargeOutcome(bool i_RechargeSuccess)
        {
            if (i_RechargeSuccess)
            {
                Console.WriteLine(string.Format(GarageSystemText.k_RechargeSuccess));
            }
            else
            {
                Console.WriteLine(string.Format(GarageSystemText.k_RechargeNoSuccess));
            }
        }

        public static void PrintRecordNotFoundWithEscapeOptionMessage(char i_EscapeKeyChar)
        {
            Console.WriteLine(GarageSystemText.k_RecordNotFoundWithEscapeOptionTemplate, i_EscapeKeyChar);
        }
    }
}
