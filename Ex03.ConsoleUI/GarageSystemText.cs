using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    internal class GarageSystemText
    {

        public const string k_WelcomeScreen =
@"======================================================

        Welcome to the Garage System Console!
        
        (press any key to continue...)

======================================================
";
        public const string k_Menue =
@"=======================================================

        Please select option from Menue:
-------------------------------------------------------
        1. Itroduce new Vehicle to Garage
        2. Display Garage Vehicles by status
        3. Change Vehicle status 
        4. Inflate Vehicle tires to max
        5. Refuel petrol powered vehicle
        6. Recharge electric powered vehicle
        7. Display vehicle details
        
=======================================================
";
        public const string k_DisplayVehicleCatalogueTemplate =
@"======================================================
Choose vehicle from menu:
1: {0}
2: {1}
3: {2}
4: {3}
=======================================================
";
        public const string k_LicenseByFilterTemplate = "License plate number {0} is in status {1}.";
        public const string k_LicnsePlateRequest = "Please input license plate number:";
        public const string k_VehicleStatusViewRequest = "Please select the vehicle status you would like to see from the following:";
        public const string k_InputErrorAlphabet = "Please insert an alphabetic character: ";
        public const string k_RequestPhoneNumber = "Please insert your phone number (no separators): ";
        public const string k_RequestLicensePlateNumber = "Please insert a valid plate number (no separators):";
        public const string k_SystemScreenHeader = "Garage System - Version 0.0.0.3";
        public const string k_StatusChangeTo = "Changed vehicle to {0} status.";
        public static string k_VehicleRecordGetOwnerName = "Please enter the owners name:";
        public static string k_VehicleRecordGetOwnerPhoneNumber = "Please enter the owners phone number:";
        public const string k_PromptResultDisplay = "Here are the results for your query: \n";
        public const string k_PressAnyKeyToContinue = "Press any key to continue...";

    }
}
