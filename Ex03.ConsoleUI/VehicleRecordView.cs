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
            VehicleOwner owner = GetNewOwner();
            //Get vehicle
            Vehicle vehicle = GetNewVehicle();
            return new VehicleRecord(vehicle,owner);
        }

        /// <summary>
        /// Create a new vehicle creation dialog
        /// </summary>
        /// <returns></returns>
        private static Vehicle GetNewVehicle()
        {
            Vehicle result = null;
            //choose type
            Console.WriteLine("select vehicle type:");
            VehicleFactory.eVehicleCatalogue selectedType =
                (VehicleFactory.eVehicleCatalogue)InputUtils.GetEnumSelectionFromType<VehicleFactory.eVehicleCatalogue>();

            string tiresManufacturer;
            string modelName;
            string licenseNumber;
            GetCommonVehicleInfo(out tiresManufacturer, out modelName, out licenseNumber);

            switch (selectedType)
            {
                case VehicleFactory.eVehicleCatalogue.ElectricMotorCycle:
                case VehicleFactory.eVehicleCatalogue.PetrolMotorCycle:
                    result = CreateMotorCycle(
                        selectedType,
                        tiresManufacturer,
                        modelName,
                        licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.ElectricCar:
                case VehicleFactory.eVehicleCatalogue.PetrolCar:
                    result = CreateCar(selectedType, tiresManufacturer, modelName, licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.Truck:
                    result = CreateTruck(
                        tiresManufacturer,
                        modelName,
                        licenseNumber);
                    break;
            }

            return result;
        }

        private static Vehicle CreateTruck(
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

        private static Vehicle CreateCar(
            VehicleFactory.eVehicleCatalogue i_SelectedType,
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            Vehicle result;
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


        private static Vehicle CreateMotorCycle(
            VehicleFactory.eVehicleCatalogue i_SelectedType,
            string i_TiresManufacturer,
            string i_ModelName,
            string i_LicenseNumber)
        {
            Vehicle result;
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
        /// Get car info needed for factory from user
        /// </summary>
        /// <param name="i_Color"></param>
        /// <param name="i_DoorsCount"></param>
        private static void GetCarInfo(out Car.eCarColor i_Color, out int i_DoorsCount)
        {
            Console.WriteLine("Please select car color: ");
            i_Color = (Car.eCarColor)InputUtils.GetEnumSelectionFromType<Car.eCarColor>();

            Console.Write("Please select number of doors: ");
            i_DoorsCount = InputUtils.GetIntFromConsole();
        }

        /// <summary>
        /// Get truck additional info needed for factory
        /// </summary>
        /// <param name="i_IsCarryingHazMats"></param>
        /// <param name="i_MaxWeight"></param>
        private static void GetTruckInfo(out bool i_IsCarryingHazMats, out float i_MaxWeight)
        {
            Console.WriteLine("Please select car color: ");
            i_IsCarryingHazMats = InputUtils.GetBooleanFromConsole('t', 'f');

            Console.Write("Please select number of doors: ");
            i_MaxWeight = InputUtils.GetFloatFromConsole();
        }

        /// <summary>
        /// Get motorcycle additional info needed for factory
        /// </summary>
        /// <param name="i_LicenseType"></param>
        /// <param name="i_EngineVolume"></param>
        private static void GetMotorcycleInfo(out Motorcycle.eLicenseType i_LicenseType, out int i_EngineVolume)
        {
            Console.WriteLine("Enter License type: ");
            i_LicenseType = (Motorcycle.eLicenseType)InputUtils.GetEnumSelectionFromType<Motorcycle.eLicenseType>();

            Console.Write("Enter engine volume: ");
            i_EngineVolume = InputUtils.GetIntFromConsole();
        }

        /// <summary>
        /// Get common vehicle info needed for factory
        /// </summary>
        /// <param name="i_TiresManufacturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        private static void GetCommonVehicleInfo(out string i_TiresManufacturer, out string i_ModelName, out string i_LicenseNumber)
        {
            Console.Write("Enter tires manufacturer name: ");
            i_TiresManufacturer = Console.ReadLine();
            Console.Write("Enter vehicle model name: ");
            i_ModelName = Console.ReadLine();
            Console.Write("Enter license number: ");
            i_LicenseNumber = Console.ReadLine();
        }

        /// <summary>
        /// Create a new owner creation dialog
        /// </summary>
        /// <returns></returns>
        private static VehicleOwner GetNewOwner()
        {
            Console.WriteLine(GarageSystemText.k_VehicleRecordGetOwnerName);
            string ownerName = Console.ReadLine();
            Console.WriteLine(GarageSystemText.k_VehicleRecordGetOwnerPhoneNumber);
            string ownerPhoneNumber = Console.ReadLine();
            return new VehicleOwner(ownerName, ownerPhoneNumber);
        }
    }
}
