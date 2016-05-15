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
            GarageSystemView.ShowScreen(GarageSystemText.k_WelcomeScreen);
            GarageSystemView.PauseForKeyStroke();
        }

        private void MenueScreen()
        {
            
            GarageSystemView.ShowScreen(GarageSystemText.k_Menue);
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
            GarageSystemView.ShowScreen(GarageSystemText.k_InsertNewVehicleScreen);
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
            GarageSystemView.ShowScreen(GarageSystemText.k_PrintByStatusScreen);
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
            GarageSystemView.ShowScreen(GarageSystemText.k_ChangeStatusScreen);
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
                Console.WriteLine(string.Format(GarageSystemText.k_StatusChangeSuccess));
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
            GarageSystemView.ShowScreen(GarageSystemText.k_InflateToMaxScreen);
            Console.WriteLine(string.Format(GarageSystemText.k_RequestLicensePlateNumber));
            string plateNumber = Console.ReadLine();
            if (GarageLogic.Garage.IsVehicleExist(plateNumber) == true)
            {
                bool inflateSucsess = GarageLogic.Garage.FillTiresToMax(plateNumber);
                if (inflateSucsess == true)
                {
                    Console.WriteLine(string.Format(GarageSystemText.k_TiresHaveBeenInflatedToMax));
                }
                else
                {
                    Console.WriteLine(string.Format(GarageSystemText.k_TiresHaveNotBeenInflatedToMax));
                }
            }
            else
            {
                Console.WriteLine(string.Format(GarageSystemText.k_RecordMatchCouldNotBeFound));
            }
            GarageSystemView.PauseForKeyStroke();
            MenueScreen();            
        }
        
        private void RefuelScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_RefuelScreen);
            Console.WriteLine(string.Format(GarageSystemText.k_RequestLicensePlateNumber));
            string plateNumber = Console.ReadLine();
            Console.WriteLine(string.Format(GarageSystemText.k_RequestFuleType));
            PetrolPowerSource.eFuelType selectedFuelType = 
                (PetrolPowerSource.eFuelType)InputUtils.GetEnumSelectionFromType<PetrolPowerSource.eFuelType>();
            Console.WriteLine(string.Format(GarageSystemText.k_RequestAmountToRefule));
            string amountToFillString = Console.ReadLine();
            float amountToFillNumber = float.Parse(amountToFillString);
            try
            {
                if (GarageLogic.Garage.FillGasTank(plateNumber, selectedFuelType, amountToFillNumber))
                {
                    Console.WriteLine(string.Format(GarageSystemText.k_RefuelSuccess));
                }
                else
                {
                    Console.WriteLine(string.Format(GarageSystemText.k_RefuelNoSuccess));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GarageSystemView.PauseForKeyStroke();
                MenueScreen();
            }
        }
        private void RechargeScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_RechargelScreen);
            Console.WriteLine(string.Format(GarageSystemText.k_RequestLicensePlateNumber));
            string plateNumber = Console.ReadLine();
            Console.WriteLine(string.Format(GarageSystemText.k_RequestMinutessToRecharge));
            string minutessToRechargeString = Console.ReadLine();
            int minutesToRechargeNumber = int.Parse(minutessToRechargeString);
            try
            {
                if (GarageLogic.Garage.FillBattery(plateNumber,minutesToRechargeNumber))
                {
                    Console.WriteLine(string.Format(GarageSystemText.k_RechargeSuccess));
                }
                else
                {
                    Console.WriteLine(string.Format(GarageSystemText.k_RechargeNoSuccess));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GarageSystemView.PauseForKeyStroke();
                MenueScreen();
            }
        }
        private void VehicelDetailsScreen()
        {

        }
    }
}
