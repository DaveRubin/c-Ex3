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
---------------------------------------------------------
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
        public const string k_VehicleStatusViewRequest = "Please insert the vehicle status you would like to see:";

    }
}