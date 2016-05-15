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
            VehicleOwner owner = CarOwnerView.GetNewOwnerDialog();
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
            VehicleView.GetCommonVehicleInfoDialog(out tiresManufacturer, out modelName, out licenseNumber);

            switch (selectedType)
            {
                case VehicleFactory.eVehicleCatalogue.ElectricMotorCycle:
                case VehicleFactory.eVehicleCatalogue.PetrolMotorCycle:
                    result = MotorcycleView.CreateMotorcycleDialog(
                        selectedType,
                        tiresManufacturer,
                        modelName,
                        licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.ElectricCar:
                case VehicleFactory.eVehicleCatalogue.PetrolCar:
                    result = CarView.CreateCarDialog(selectedType, tiresManufacturer, modelName, licenseNumber);
                    break;

                case VehicleFactory.eVehicleCatalogue.Truck:
                    result = TruckView.CreateTruckDialog(
                        tiresManufacturer,
                        modelName,
                        licenseNumber);
                    break;
            }

            return result;
        }
    }
}
