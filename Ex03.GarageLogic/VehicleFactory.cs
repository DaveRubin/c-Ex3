using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class VehicleFactory
    {
        public enum eVehicleCatalogue
        {
            PetrolMotorCycle = 0,
            ElectricMotorCycle = 1,
            ElectricCar = 2,
            PetrolCar = 3,
            Truck = 4
        }

        private const int k_MotorcycleAirPressure = 31;
        private const int k_CarAirPressure = 30;
        private const int k_TruckAirPressure = 28;
        private const int k_MotorcycleTires = 2;
        private const int k_CarTires = 4;
        private const int k_TruckTires = 16;
        private const float k_ElectricMotorcycleMaxHours = 1.9f;
        private const float k_ElectricCarMaxHours = 3.3f;
        private const float k_PetrolMotorcycleMaxAmount = 7.2f;
        private const float k_PetrolCarMaxAmount = 38;
        private const float k_TruckMaxAmount = 135;
        private const PetrolPowerSource.eFuelType k_PetrolCarFuelType = PetrolPowerSource.eFuelType.Octan98;
        private const PetrolPowerSource.eFuelType k_PetrolMotorcycleFuelType = PetrolPowerSource.eFuelType.Octan95;
        private const PetrolPowerSource.eFuelType k_PetrolTruckFuelType = PetrolPowerSource.eFuelType.Soler;

        /// <summary>
        /// Create a new petrol motorcycle
        /// </summary>
        /// <param name="i_TiresMenufecturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        /// <param name="i_LicencType"></param>
        /// <param name="i_EngineVolume"></param>
        /// <returns></returns>
        public static PetrolMotorCycle CreatePetrolMotorCycle(
            string i_TiresMenufecturer,
            string i_ModelName,
            string i_LicenseNumber,
            Motorcycle.eLicenseType i_LicencType,
            int i_EngineVolume)
        {
            PetrolMotorCycle result;

            List<Tire> tires = GetTires(k_MotorcycleTires, i_TiresMenufecturer, k_MotorcycleAirPressure);
            result = new PetrolMotorCycle(
                k_PetrolMotorcycleFuelType,
                k_PetrolMotorcycleMaxAmount,
                i_ModelName,
                i_LicenseNumber,
                tires,
                i_LicencType,
                i_EngineVolume);
            return result;
        }

        /// <summary>
        /// Create a new electric motorcycle
        /// </summary>
        /// <param name="i_TiresMenufecturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        /// <param name="i_LicencType"></param>
        /// <param name="i_EngineVolume"></param>
        /// <returns></returns>
        public static ElectricMotorCycle CreateElectricMotorcycle(
            string i_TiresMenufecturer,
            string i_ModelName,
            string i_LicenseNumber,
            Motorcycle.eLicenseType i_LicencType,
            int i_EngineVolume)
        {
            ElectricMotorCycle result;

            List<Tire> tires = GetTires(k_MotorcycleTires, i_TiresMenufecturer, k_MotorcycleAirPressure);
            result = new ElectricMotorCycle(
                k_ElectricMotorcycleMaxHours,
                i_ModelName,
                i_LicenseNumber,
                tires,
                i_LicencType,
                i_EngineVolume);
            return result;
        }

        /// <summary>
        /// Create a new electric car
        /// </summary>
        /// <param name="i_TiresMenufecturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenceNumber"></param>
        /// <param name="i_tiers"></param>
        /// <param name="i_Color"></param>
        /// <param name="i_DoorsCount"></param>
        /// <returns></returns>
        public static ElectricCar CreateElectricCar(
            string i_TiresMenufecturer,
            string i_ModelName,
            string i_LicenceNumber,
            Car.eCarColor i_Color,
            int i_DoorsCount)
        {
            ElectricCar result;

            List<Tire> tires = GetTires(k_CarTires, i_TiresMenufecturer, k_CarAirPressure);
            result = new ElectricCar(k_ElectricCarMaxHours, i_ModelName, i_LicenceNumber, tires, i_Color, i_DoorsCount);
            return result;
        }

        /// <summary>
        /// Create new patrol car
        /// </summary>
        /// <param name="i_TiresMenufecturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenceNumber"></param>
        /// <param name="i_Color"></param>
        /// <param name="i_DoorsCount"></param>
        /// <returns></returns>
        public static PetrolCar CreatePetrolCar(
            string i_TiresMenufecturer,
            string i_ModelName,
            string i_LicenceNumber,
            Car.eCarColor i_Color,
            int i_DoorsCount)
        {
            PetrolCar result;

            List<Tire> tires = GetTires(k_CarTires, i_TiresMenufecturer, k_CarAirPressure);
            result = new PetrolCar(
                k_PetrolCarFuelType,
                k_PetrolCarMaxAmount,
                i_ModelName,
                i_LicenceNumber,
                tires,
                i_Color,
                i_DoorsCount);
            return result;
        }

        /// <summary>
        /// Create new truck
        /// </summary>
        /// <param name="i_TiresMenufecturer"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenceNumber"></param>
        /// <param name="i_IsCarryingHazardousMaterials"></param>
        /// <param name="i_MaxWeightAllowed"></param>
        /// <returns></returns>
        public static Truck CreateTruck(
            string i_TiresMenufecturer,
            string i_ModelName,
            string i_LicenceNumber,
            bool i_IsCarryingHazardousMaterials,
            float i_MaxWeightAllowed)
        {
            Truck result;
            List<Tire> tires = GetTires(k_TruckTires, i_TiresMenufecturer, k_TruckAirPressure);
            result = new Truck(
                k_PetrolTruckFuelType,
                k_TruckMaxAmount,
                i_ModelName,
                i_LicenceNumber,
                tires,
                i_IsCarryingHazardousMaterials,
                i_MaxWeightAllowed);
            return result;
        }

        /// <summary>
        /// Create a set of tires
        /// </summary>
        /// <param name="i_NumOfTires"></param>
        /// <param name="i_ManufacturerName"></param>
        /// <param name="i_AirPressure"></param>
        /// <returns></returns>
        private static List<Tire> GetTires(int i_NumOfTires, string i_ManufacturerName, float i_AirPressure)
        {
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < i_NumOfTires; i++)
            {
                Tire tire = new Tire(i_ManufacturerName, i_AirPressure);
                tires.Add(tire);
            }

            return tires;
        }
    }
}
