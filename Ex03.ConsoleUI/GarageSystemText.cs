﻿using System;
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

        public const string k_InsertNewVehicleScreen =
@"======================================================
                INSERT NEW VEHICLE SCREEN
======================================================
";

        public const string k_PrintByStatusScreen =
@"======================================================
            PRINT LICENSE BY STATUS SCREEN
======================================================
";

        public const string k_ChangeStatusScreen =
@"======================================================
                CHANGE STATUS SCREEN
======================================================
";

        public const string k_InflateToMaxScreen =
@"======================================================
                INFLATE TO MAX SCREEN
======================================================
";

        public const string k_RefuelScreen =
@"======================================================
                REFUEL SCREEN
======================================================
";

        public const string k_RechargelScreen =
@"======================================================
                RECHARGE SCREEN
======================================================
";

        public const string k_PrintVehicleDetailsScreen =
@"======================================================
            PRINT VEHICLE DETAILS SCREEN
======================================================
";

        public const string k_LicenseByFilterTemplate = "License plate number {0} is in status {1}.";
        public const string k_LicnsePlateRequest = "Please input license plate number:";
        public const string k_VehicleStatusViewRequest = "Please select the vehicle status you would like to see from the following:";
        public const string k_InputErrorAlphabet = "Please insert an alphabetic character: ";
        public const string k_RequestPhoneNumber = "Please insert your phone number (no separators): ";
        public const string k_RequestLicensePlateNumber = "Please insert a valid plate number (no separators):";
        public const string k_RequestFuleType = "Please ipnut with which kind of fuel would you like to fill the tank:";
        public const string k_RequestAmountToRefule = "Please ipnut with how much fuel to fill the tank:";
        public const string k_RequestMinutessToRecharge = "Please ipnut with how many minutes you would like to recharge:";
        public const string k_SystemScreenHeader = "Garage System - Version 0.0.0.3";
        public const string k_PromptResultDisplay = "Here are the results for your query: \n";
        public const string k_PressAnyKeyToContinue = "Press any key to continue...";
        public const string k_TiresHaveBeenInflatedToMax = "Vehicle tires have been successfuly infalted to max capacity.";
        public const string k_TiresHaveNotBeenInflatedToMax = "Vehicle tires have NOT been infalted to max capacity.";
        public const string k_RecordMatchCouldNotBeFound = "Could not find record that mathces your input";
        public const string k_StatusChangeSuccess = "Status changed successfuly to {0}";
        public const string k_StatusChangeNoSuccess = "Status changed UNSUCCESSFUL!";
        public const string k_RefuelSuccess = "Refuel successful!";
        public const string k_RefuelNoSuccess = "Refuel UNSUCCESSFUL!";
        public const string k_RechargeSuccess = "Recharge successful!";
        public const string k_RechargeNoSuccess = "Recharge UNSUCCESSFUL!"; 
        public const string k_StatusChangeTo = "Changed vehicle to {0} status.";
        public const string k_VehicleRecordGetOwnerName = "Please enter the owners name:";
        public const string k_VehicleRecordGetOwnerPhoneNumber = "Please enter the owners phone number:";
        public const string k_CarInfoGetColorMessage = "Please select car color: ";
        public const string k_CarInfoGetDoorsCountMessage = "Please select number of doors: ";
        public const string k_StatusChangedAfterInsertionMessage = "changed vehicle to in repair status";
        public const string k_RecordAddedSuccessfulyMessage = "record added successfuly";
        public const string k_VehicleGetLicenseNumberMessage = "Enter license number: ";
        public const string k_VehicleGetVehicleModelNameMessage = "Enter vehicle model name: ";
        public const string k_VehicleGetTiresManufacturerNameMessage = "Enter tires manufacturer name: ";
        public const string k_MotorcycleEnterEngineVolumeMessage = "Enter engine volume: ";
        public const string k_MotorcycleEnterLicenseMessage = "Enter License type: ";
        public const string k_VehicleRecordSelectVehicleTypeMessage = "select vehicle type:";
        public const string k_TruckEnterIsHazMatMessageTemplate = "Is carrying harardouse materials? {0} for yes, {1} for no:";
        public const string k_TruckEnterMaxWeightMessage = "Enter max weight allowed";
        public const string k_RecordNotFoundWithEscapeOptionTemplate = "Record was not found, press '{0}' to main menue or press any other key to continue:";

        // vehicle full details templates
        public const string k_VehicleViewTemplate = @"----------------------------------
Vehicle:
{0}
Owner:
{1}
Tires:
{2}
Vehicle power source:
{3}
Vehicle specific details:
{4}
----------------------------------
";

        public const string k_TruckViewTemplate = @"Carrying hazardous materials : {0}
Weight limit: {1}";

        public const string k_TirePairTemplate = @"{0,-20} {1}
";

        public const string k_TireAirPressureTemplate = "{0}/{1}";
        public const string k_TireManufecturerHeaderText = "Manufacturer";
        public const string k_TireAirPressureHeaderText = "Air pressure";
        public const string k_TireColumnUnderlineText = "------------";
        public const string k_PetrolPowerSourceViewTemplate = @"Fuel left : {0}/{1}
Fuel type: {2}";

        public const string k_MotorcycleViewTemplate = @"License type : {0}
Engine volume (cc): {1}";

        public const string k_FullDetailsTemplate = @"License number: {0}
Model name: {1}";

        public const string k_ElectricPowerSourceViewTemplate = @"Hours Left : {0}/{1}";
        public const string k_CarViewTemplate = @"Car color : {0}
Number of doors: {1}";

        public const string k_OwnerVehicleViewTemplate = @"Owner name: {0}
Vehicle status: {1}";
    }
}
