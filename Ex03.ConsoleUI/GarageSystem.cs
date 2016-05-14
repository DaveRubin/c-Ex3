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
                    VehiclesLicenseByStatusScreen();
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
                Console.WriteLine("changed vehicle to in repair status");
                Garage.ChangeVehicleStatusTo(plateNumber, Garage.eVehicleStatus.BeingFixed);
            }
            else
            {
                Console.WriteLine("record added successfuly");
                //add new vehicle
                Garage.InsertVehicleRecord(newRecord.m_Vehicle, newRecord.m_Owner);
            }
            Console.ReadLine();
            MenueScreen();
        }

        private void VehiclesLicenseByStatusScreen()
        {
            GarageSystemView.PrintSystemHeader();
            Garage.eVehicleStatus statusFilter = GarageSystemView.RequestStatusFromUser();
            List<string> mathcedEntries = Garage.GetLicensePlatesByStatus(statusFilter);
            GarageSystemView.PromptResultsDisplay();
            foreach (string plate in mathcedEntries)
            {
                Console.WriteLine(plate);
            }
            GarageSystemView.PauseForKeyStroke();
            MenueScreen();
        }
        
        private void StatusChangeScreen()
        {
            GarageSystemView.PrintSystemHeader();
            GarageLogic.VehicleRecord vehicleRecordToChange = GarageSystemView.RequestVehicleRecordByLicensePlateNumber();
            // TODO: no way to nullify the enum. how should this variable be initialized?
            Garage.eVehicleStatus statusToChangeTo = Garage.eVehicleStatus.BeingFixed;
            if (vehicleRecordToChange != null)
            {
                statusToChangeTo = GarageSystemView.RequestStatusFromUser();
            }
            else
            {
                MenueScreen();
            }

            try
            {
                vehicleRecordToChange.m_Status = statusToChangeTo;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                StatusChangeScreen();
            }
            GarageSystemView.PauseForKeyStroke();
            MenueScreen();
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
