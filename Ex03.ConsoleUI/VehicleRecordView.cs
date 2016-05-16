using System;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class VehicleRecordView
    {
        public static VehicleRecord GetNewVehicleRecord()
        {
            // Get owner info
            VehicleOwner owner = GetNewOwnerDialog();

            // Get vehicle
            Vehicle vehicle = GetNewVehicle();
            return new VehicleRecord(vehicle, owner);
        }

        /// <summary>
        /// Create a new owner creation dialog
        /// </summary>
        /// <returns></returns>
        public static VehicleOwner GetNewOwnerDialog()
        {
            VehicleOwnerView.PrintVehicleRecordGetOwnerName();
            string ownerName = Console.ReadLine();
            VehicleOwnerView.VehicleRecordGetOwnerPhoneNumber();
            string ownerPhoneNumber = Console.ReadLine();
            return new VehicleOwner(ownerName, ownerPhoneNumber);
        }

        /// <summary>
        /// Create a new vehicle creation dialog
        /// </summary>
        /// <returns></returns>
        private static Vehicle GetNewVehicle()
        {
            Vehicle result = null;
            string tiresManufacturer;
            string modelName;
            string licenseNumber;

            // choose type
            GarageSystemView.PrintVehicleRecordSelectVehicleTypeMessage();
            VehicleFactory.eVehicleCatalogue selectedType =
                (VehicleFactory.eVehicleCatalogue)InputUtils.GetEnumSelectionFromType<VehicleFactory.eVehicleCatalogue>();

            GetCommonVehicleInfoDialog(out tiresManufacturer, out modelName, out licenseNumber);

            switch (selectedType)
            {
                case VehicleFactory.eVehicleCatalogue.ElectricMotorCycle:
                case VehicleFactory.eVehicleCatalogue.PetrolMotorCycle:
                    result = CreateMotorcycleDialog(selectedType, tiresManufacturer, modelName, licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.ElectricCar:
                case VehicleFactory.eVehicleCatalogue.PetrolCar:
                    result = CreateCarDialog(selectedType, tiresManufacturer, modelName, licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.Truck:
                    result = CreateTruckDialog(tiresManufacturer, modelName, licenseNumber);
                    break;
            }

            return result;
        }

        private static Truck CreateTruckDialog(string i_TiresManufacturer, string i_ModelName, string i_LicenseNumber)
        {
            bool isCarryingHazMats;
            float maxWeight;

            GetTruckInfo(out isCarryingHazMats, out maxWeight);

            return VehicleFactory.CreateTruck(
                i_TiresManufacturer,
                i_ModelName,
                i_LicenseNumber,
                isCarryingHazMats,
                maxWeight);
        }

        /// <summary>
        /// Get truck additional info needed for factory
        /// </summary>
        /// <param name="o_IsCarryingHazMats"></param>
        /// <param name="o_MaxWeight"></param>
        private static void GetTruckInfo(out bool o_IsCarryingHazMats, out float o_MaxWeight)
        {
            TruckView.PrintEnterIsHazMatMessage(GarageKeys.k_True, GarageKeys.k_False);
            o_IsCarryingHazMats = InputUtils.GetBooleanFromConsole(GarageKeys.k_True, GarageKeys.k_False);

            TruckView.PrintEnterMaxWeightMessage();
            o_MaxWeight = InputUtils.GetFloatFromConsole();
        }

        private static Motorcycle CreateMotorcycleDialog(
            VehicleFactory.eVehicleCatalogue i_SelectedType,
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            Motorcycle result;
            Motorcycle.eLicenseType licenseType;
            int engineVolume;

            GetMotorcycleInfo(out licenseType, out engineVolume);

            if (i_SelectedType == VehicleFactory.eVehicleCatalogue.ElectricMotorCycle)
            {
                result = VehicleFactory.CreateElectricMotorcycle(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    licenseType,
                    engineVolume);
            }
            else
            {
                result = VehicleFactory.CreatePetrolMotorCycle(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    licenseType,
                    engineVolume);
            }

            return result;
        }

        /// <summary>
        /// Get motorcycle additional info needed for factory
        /// </summary>
        /// <param name="o_LicenseType"></param>
        /// <param name="o_EngineVolume"></param>
        private static void GetMotorcycleInfo(out Motorcycle.eLicenseType o_LicenseType, out int o_EngineVolume)
        {
            MotorcycleView.PrintEnterLicenseMessage();
            o_LicenseType = (Motorcycle.eLicenseType)InputUtils.GetEnumSelectionFromType<Motorcycle.eLicenseType>();

            MotorcycleView.PrintEnterEngineVolumeMessage();
            o_EngineVolume = InputUtils.GetIntFromConsole();
        }

        /// <summary>
        /// Get common vehicle info needed for factory
        /// </summary>
        /// <param name="o_TiresManufacturer"></param>
        /// <param name="o_ModelName"></param>
        /// <param name="o_LicenseNumber"></param>
        private static void GetCommonVehicleInfoDialog(
            out string o_TiresManufacturer,
            out string o_ModelName,
            out string o_LicenseNumber)
        {
            VehicleView.PrintGetTiresManufacturerNameMessage();
            o_TiresManufacturer = Console.ReadLine();
            VehicleView.PrintGetVehicleModelNameMessage();
            o_ModelName = Console.ReadLine();
            VehicleView.PrintGetLicenseNumberMessage();
            o_LicenseNumber = Console.ReadLine();
        }

        private static Car CreateCarDialog(
            VehicleFactory.eVehicleCatalogue i_SelectedType,
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            Car result;
            Car.eCarColor color;
            int doorsCount;

            GetCarInfo(out color, out doorsCount);

            if (i_SelectedType == VehicleFactory.eVehicleCatalogue.ElectricCar)
            {
                result = VehicleFactory.CreateElectricCar(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    color,
                    doorsCount);
            }
            else
            {
                result = VehicleFactory.CreatePetrolCar(
                    i_TiresManufacturer,
                    i_ModelName,
                    i_LicenseNumber,
                    color,
                    doorsCount);
            }

            return result;
        }

        /// <summary>
        /// Get car info needed for factory from user
        /// </summary>
        /// <param name="o_Color"></param>
        /// <param name="o_DoorsCount"></param>
        private static void GetCarInfo(out Car.eCarColor o_Color, out int o_DoorsCount)
        {
            CarView.PrintGetColorMessage();
            o_Color = (Car.eCarColor)InputUtils.GetEnumSelectionFromType<Car.eCarColor>();

            CarView.GetDoorsCountMessage();
            o_DoorsCount = InputUtils.GetIntFromConsole();
        }
    }
}
