using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

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
            VehicleRecord newRecord = VehicleRecordView.GetNewVehicleRecord();
            string plateNumber = newRecord.m_Vehicle.r_LicenseNumber;
            if (Garage.IsVehicleExist(plateNumber))
            {
                //change to "in repair" status
                Garage.ChangeVehicleStatusTo(plateNumber, Garage.eVehicleStatus.BeingFixed);
            }
            else
            {
                //add new vehicle
                Garage.InsertVehicleRecord(newRecord.m_Vehicle, newRecord.m_Owner);
            }
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
