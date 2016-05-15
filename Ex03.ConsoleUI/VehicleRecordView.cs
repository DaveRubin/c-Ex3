using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class VehicleRecordView
    {
        public static VehicleRecord GetNewVehicleRecord()
        {
            //Get owner info
            VehicleOwner owner = GetNewOwnerDialog();
            //Get vehicle
            Vehicle vehicle = GetNewVehicle();
            return new VehicleRecord(vehicle,owner);
        }

        /// <summary>
        /// Create a new owner creation dialog
        /// </summary>
        /// <returns></returns>
        public static VehicleOwner GetNewOwnerDialog()
        {
            CarOwnerView.PrintVehicleRecordGetOwnerName();
            string ownerName = Console.ReadLine();
            CarOwnerView.VehicleRecordGetOwnerPhoneNumber();
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

            //choose type
            GarageSystemView.PrintVehicleRecordSelectVehicleTypeMessage();
            VehicleFactory.eVehicleCatalogue selectedType =
                (VehicleFactory.eVehicleCatalogue)InputUtils.GetEnumSelectionFromType<VehicleFactory.eVehicleCatalogue>();

            GetCommonVehicleInfoDialog(out tiresManufacturer, out modelName, out licenseNumber);

            switch (selectedType)
            {
                case VehicleFactory.eVehicleCatalogue.ElectricMotorCycle:
                case VehicleFactory.eVehicleCatalogue.PetrolMotorCycle:
                    result = CreateMotorcycleDialog(
                        selectedType,
                        tiresManufacturer,
                        modelName,
                        licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.ElectricCar:
                case VehicleFactory.eVehicleCatalogue.PetrolCar:
                    result = CreateCarDialog(selectedType, tiresManufacturer, modelName, licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.Truck:
                    result = CreateTruckDialog(
                        tiresManufacturer,
                        modelName,
                        licenseNumber);
                    break;
            }

            return result;
        }

        public static Truck CreateTruckDialog(
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
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
        /// <param name="i_IsCarryingHazMats"></param>
        /// <param name="i_MaxWeight"></param>
        private static void GetTruckInfo(out bool i_IsCarryingHazMats, out float i_MaxWeight)
        {
            TruckView.PrintEnterIsHazMatMessage();
            i_IsCarryingHazMats = InputUtils.GetBooleanFromConsole('t', 'f');

            TruckView.PrintEnterMaxWeightMessage();
            i_MaxWeight = InputUtils.GetFloatFromConsole();
        }

        public static Motorcycle CreateMotorcycleDialog(
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
        /// <param name="i_LicenseType"></param>
        /// <param name="i_EngineVolume"></param>
        private static void GetMotorcycleInfo(out Motorcycle.eLicenseType i_LicenseType, out int i_EngineVolume)
        {
            MotorcycleView.PrintEnterLicenseMessage();
            i_LicenseType = (Motorcycle.eLicenseType)InputUtils.GetEnumSelectionFromType<Motorcycle.eLicenseType>();

            MotorcycleView.PrintEnterEngineVolumeMessage();
            i_EngineVolume = InputUtils.GetIntFromConsole();
        }

        /// <summary>
        /// Get common vehicle info needed for factory
        /// </summary>
        /// <param name="i_TiresManufacturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        public static void GetCommonVehicleInfoDialog(out string i_TiresManufacturer, out string i_ModelName, out string i_LicenseNumber)
        {
            VehicleView.PrintGetTiresManufacturerNameMessage();
            i_TiresManufacturer = Console.ReadLine();
            VehicleView.PrintGetVehicleModelNameMessage();
            i_ModelName = Console.ReadLine();
            VehicleView.PrintGetLicenseNumberMessage();
            i_LicenseNumber = Console.ReadLine();
        }

        public static Car CreateCarDialog(
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
        /// <param name="i_Color"></param>
        /// <param name="i_DoorsCount"></param>
        public static void GetCarInfo(out Car.eCarColor i_Color, out int i_DoorsCount)
        {
            CarView.PrintGetColorMessage();
            i_Color = (Car.eCarColor)InputUtils.GetEnumSelectionFromType<Car.eCarColor>();

            CarView.GetDoorsCountMessage();
            i_DoorsCount = InputUtils.GetIntFromConsole();
        }
    }
}
