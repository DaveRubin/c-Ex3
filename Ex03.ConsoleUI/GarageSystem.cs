using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    class GarageSystem
    {
        public GarageSystem()
        {
            WelcomeScreen();
            MenueScreen();
        }

        private void WelcomeScreen()
        {
            GarageSystemView.ShowWelcomeScreen();
        }

        private void MenueScreen()
        {
            GarageSystemView.ShowMenueScreen();
            //TODO: decide how to not use numbers and use variables instead
            int userInput = InputUtils.GetBoundedIntFromConsole(1, 7);
            switch (userInput)
            {
                case 1:
                    NewVehicleScreen();
                    break;
                case 2:
                    VehiclesByStatusScreen();
                    break;
                case 3:
                    StatusChangeScreen();
                    break;
                case 4:
                    InflateVehicleScreen();
                    break;
                case 5:
                    RefuelScreen();
                    break;
                case 6:
                    RechargeScreen();
                    break;
                case 7:
                    VehicelDetailsScreen();
                    break;
            }
        }

        private void NewVehicleScreen()
        {
            GarageSystemView.PrintSystemHeader();
            GarageSystemView.RequestLicensePlateNumber();
            string plateNumber = Console.ReadLine();
            //TODO: read the plate number and validate it, if it's already in use assert, if not create vehicle
            //and assign new/existing owner
            
        }

        private void VehiclesByStatusScreen()
        {

        }
        
        private void StatusChangeScreen()
        {

        }

        private void InflateVehicleScreen()
        {

        }
        
        private void RefuelScreen()
        {

        }
        private void RechargeScreen()
        {

        }
        private void VehicelDetailsScreen()
        {

        }
    }
}
