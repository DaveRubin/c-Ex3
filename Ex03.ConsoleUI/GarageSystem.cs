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
            VehicleRecord newRecord = null;
            try
            {
                newRecord = VehicleRecordView.GetNewVehicleRecord();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GarageSystemView.PauseForKeyStroke();
                NewVehicleScreen();
            }
            string plateNumber = newRecord.m_Vehicle.r_LicenseNumber;
            if (Garage.IsVehicleExist(plateNumber))
            {
                //change to "in repair" status
                Garage.ChangeVehicleStatusTo(plateNumber, Garage.eVehicleStatus.BeingFixed);
                GarageSystemView.PrintStatusChangedSuccesfullyMessage(Garage.eVehicleStatus.BeingFixed);
            }
            else
            {
                //add new vehicle
                GarageSystemView.PrintRecordAddedSuccessfulyMessage();
                Garage.InsertVehicleRecord(newRecord.m_Vehicle, newRecord.m_Owner);
            }
            Console.ReadLine();
            MenueScreen();
        }

        private void VehiclesLicenseByStatusScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_PrintByStatusScreen);
            Garage.eVehicleStatus statusFilter = RequestStatusFromUser();
            List<string> mathcedEntries = Garage.GetLicensePlatesByStatus(statusFilter);
            GarageSystemView.PromptResultsDisplay(mathcedEntries);
            GarageSystemView.PauseForKeyStroke();
            MenueScreen();
        }
        
        private void StatusChangeScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_ChangeStatusScreen);
            VehicleRecord vehicleRecordToChange = RequestVehicleRecordByLicensePlateNumber();
            // TODO: no way to nullify the enum. how should this variable be initialized?
            Garage.eVehicleStatus statusToChangeTo = Garage.eVehicleStatus.BeingFixed;
            if (vehicleRecordToChange != null)
            {
                statusToChangeTo = RequestStatusFromUser();
            }
            else
            {
                MenueScreen();
            }

            try
            {
                vehicleRecordToChange.m_Status = statusToChangeTo;
                GarageSystemView.PrintStatusChangedSuccesfullyMessage(vehicleRecordToChange.m_Status);
            }
            catch(Exception ex)
            {
                GarageSystemView.PrintExceptionMessage(ex.Message);
                StatusChangeScreen();
            }
            GarageSystemView.PauseForKeyStroke();
            MenueScreen();
        }

        private VehicleRecord RequestVehicleRecordByLicensePlateNumber()
        {

            VehicleRecord result = null;
            GarageSystemView.PrintSystemHeader();
            GarageSystemView.PrintRequestLicensePlateNumberMessage();

            string userInput = Console.ReadLine();
            if (Garage.IsVehicleExist(userInput))
            {
                result = Garage.GetRecordByPlateNumber(userInput);
            }
            else
            {
                GarageSystemView.PrintRecordNotFoundWithEscapeOptionMessage(GarageKeys.k_EscapeKeyChar);

                char userInputAfterError = Console.ReadKey().KeyChar;
                if (!userInputAfterError.Equals(GarageKeys.k_EscapeKeyChar))
                {
                    result = RequestVehicleRecordByLicensePlateNumber();
                }
            }

            return result;
        }

        private void InflateVehicleScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_InflateToMaxScreen);
            GarageSystemView.PrintRequestLicensePlateNumberMessage();
            string plateNumber = Console.ReadLine();
            if (Garage.IsVehicleExist(plateNumber) == true)
            {
                bool inflateSucsess = Garage.FillTiresToMax(plateNumber);
                if (inflateSucsess == true)
                {
                    GarageSystemView.PrintTiresFilledSuccess(true);
                }
                else
                {
                    GarageSystemView.PrintTiresFilledSuccess(false);
                }
            }
            else
            {
                GarageSystemView.PrintRecordMatchCouldNotBeFount();
            }
            GarageSystemView.PauseForKeyStroke();
            MenueScreen();            
        }
        
        private void RefuelScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_RefuelScreen);
            GarageSystemView.PrintRequestLicensePlateNumberMessage();
            string plateNumber = Console.ReadLine();
            GarageSystemView.PrintRequestRefuelTypeMessage();
            PetrolPowerSource.eFuelType selectedFuelType = 
                (PetrolPowerSource.eFuelType)InputUtils.GetEnumSelectionFromType<PetrolPowerSource.eFuelType>();
            GarageSystemView.PrintRequestRefuelAmountMessage();
            float amountToFillNumber = InputUtils.GetFloatFromConsole();

            try
            {
                if (Garage.FillGasTank(plateNumber, selectedFuelType, amountToFillNumber))
                {
                    GarageSystemView.PrintRefuelOutcomeMessage(true);
                }
                else
                {
                    GarageSystemView.PrintRefuelOutcomeMessage(false);
                }
            }
            catch(Exception ex)
            {
                GarageSystemView.PrintExceptionMessage(ex.Message);
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
            GarageSystemView.PrintRequestLicensePlateNumberMessage();
            string plateNumber = Console.ReadLine();
            GarageSystemView.PrintRequestMinutesToChargeMessage();
            int minutesToRechargeNumber = InputUtils.GetIntFromConsole();
            try
            {
                if (Garage.FillBattery(plateNumber,minutesToRechargeNumber))
                {
                    GarageSystemView.PrintRechargeOutcome(true);
                }
                else
                {
                    GarageSystemView.PrintRechargeOutcome(false);
                }
            }
            catch(Exception ex)
            {
                GarageSystemView.PrintExceptionMessage(ex.Message);
            }
            finally
            {
                GarageSystemView.PauseForKeyStroke();
                MenueScreen();
            }
        }

        private void VehicelDetailsScreen()
        {
            GarageSystemView.ShowScreen(GarageSystemText.k_PrintVehicleDetailsScreen);
            GarageSystemView.PrintRequestLicensePlateNumberMessage();
            string userInput = Console.ReadLine();

            if (Garage.IsVehicleExist(userInput))
            {
               VehicleView.PrintFullDetails(Garage.GetRecordByPlateNumber(userInput));
            }
            else
            {
                GarageSystemView.PrintRecordNotFoundWithEscapeOptionMessage(GarageKeys.k_EscapeKeyChar);

                char userInputAfterError = Console.ReadKey().KeyChar;
                if (!userInputAfterError.Equals(GarageKeys.k_EscapeKeyChar))
                {
                    VehicelDetailsScreen();
                }
            }

            GarageSystemView.PauseForKeyStroke();
            MenueScreen();
        }


        private static Garage.eVehicleStatus RequestStatusFromUser()
        {
            Garage.eVehicleStatus result = Garage.eVehicleStatus.BeingFixed;

            GarageSystemView.PrintSystemHeader();
            GarageSystemView.PrintFilterByVehicleStatusMessage();
            string userInput = Console.ReadLine();

            try
            {
                Garage.eVehicleStatus statusSelected = (Garage.eVehicleStatus)Enum.Parse(
                 typeof(Garage.eVehicleStatus), userInput);
                result = statusSelected;
            }
            catch (ArgumentException ex)
            {
                GarageSystemView.PrintExceptionMessage(ex.Message);
                GarageSystemView.PauseForKeyStroke();
                RequestStatusFromUser();
            }

            return result;
        }
    }
}
