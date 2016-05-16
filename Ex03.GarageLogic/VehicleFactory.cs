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
        /// <param name="i_tiresMenufecturer"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_licencType"></param>
        /// <param name="i_engineVolume"></param>
        /// <returns></returns>
        public static PetrolMotorCycle CreatePetrolMotorCycle(
            string i_tiresMenufecturer,
            string i_modelName,
            string i_licenseNumber,
            Motorcycle.eLicenseType i_licencType,
            int i_engineVolume)
        {
            PetrolMotorCycle result;

            List<Tire> tires = GetTires(k_MotorcycleTires, i_tiresMenufecturer, k_MotorcycleAirPressure);
            result = new PetrolMotorCycle(
                k_PetrolMotorcycleFuelType,
                k_PetrolMotorcycleMaxAmount,
                i_modelName,
                i_licenseNumber,
                tires,
                i_licencType,
                i_engineVolume);
            return result;
        }

        /// <summary>
        /// Create a new electric motorcycle
        /// </summary>
        /// <param name="i_tiresMenufecturer"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_licencType"></param>
        /// <param name="i_engineVolume"></param>
        /// <returns></returns>
        public static ElectricMotorCycle CreateElectricMotorcycle(
            string i_tiresMenufecturer,
            string i_modelName,
            string i_licenseNumber,
            Motorcycle.eLicenseType i_licencType,
            int i_engineVolume)
        {
            ElectricMotorCycle result;

            List<Tire> tires = GetTires(k_MotorcycleTires, i_tiresMenufecturer, k_MotorcycleAirPressure);
            result = new ElectricMotorCycle(
                k_ElectricMotorcycleMaxHours,
                i_modelName,
                i_licenseNumber,
                tires,
                i_licencType,
                i_engineVolume);
            return result;
        }

        /// <summary>
        /// Create a new electric car
        /// </summary>
        /// <param name="i_tiresMenufecturer"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenceNumber"></param>
        /// <param name="i_tiers"></param>
        /// <param name="i_color"></param>
        /// <param name="i_doorsCount"></param>
        /// <returns></returns>
        public static ElectricCar CreateElectricCar(
            string i_tiresMenufecturer,
            string i_modelName,
            string i_licenceNumber,
            Car.eCarColor i_color,
            int i_doorsCount)
        {
            ElectricCar result;

            List<Tire> tires = GetTires(k_CarTires, i_tiresMenufecturer, k_CarAirPressure);
            result = new ElectricCar(k_ElectricCarMaxHours, i_modelName, i_licenceNumber, tires, i_color, i_doorsCount);
            return result;
        }

        /// <summary>
        /// Create new patrol car
        /// </summary>
        /// <param name="i_tiresMenufecturer"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenceNumber"></param>
        /// <param name="i_color"></param>
        /// <param name="i_doorsCount"></param>
        /// <returns></returns>
        public static PetrolCar CreatePetrolCar(
            string i_tiresMenufecturer,
            string i_modelName,
            string i_licenceNumber,
            Car.eCarColor i_color,
            int i_doorsCount)
        {
            PetrolCar result;

            List<Tire> tires = GetTires(k_CarTires, i_tiresMenufecturer, k_CarAirPressure);
            result = new PetrolCar(
                k_PetrolCarFuelType,
                k_PetrolCarMaxAmount,
                i_modelName,
                i_licenceNumber,
                tires,
                i_color,
                i_doorsCount);
            return result;
        }

        /// <summary>
        /// Create new truck
        /// </summary>
        /// <param name="i_tiresMenufecturer"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenceNumber"></param>
        /// <param name="i_IsCarryingHazardousMaterials"></param>
        /// <param name="i_MaxWeightAllowed"></param>
        /// <returns></returns>
        public static Truck CreateTruck(
            string i_tiresMenufecturer,
            string i_modelName,
            string i_licenceNumber,
            bool i_IsCarryingHazardousMaterials,
            float i_MaxWeightAllowed)
        {
            Truck result;
            List<Tire> tires = GetTires(k_TruckTires, i_tiresMenufecturer, k_TruckAirPressure);
            result = new Truck(
                k_PetrolTruckFuelType,
                k_TruckMaxAmount,
                i_modelName,
                i_licenceNumber,
                tires,
                i_IsCarryingHazardousMaterials,
                i_MaxWeightAllowed);
            return result;
        }

        /// <summary>
        /// Create a set of tires
        /// </summary>
        /// <param name="i_numOfTires"></param>
        /// <param name="i_manufacturerName"></param>
        /// <param name="i_airPressure"></param>
        /// <returns></returns>
        private static List<Tire> GetTires(int i_numOfTires, string i_manufacturerName, float i_airPressure)
        {
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < i_numOfTires; i++)
            {
                Tire tire = new Tire(i_manufacturerName, i_airPressure);
                tires.Add(tire);
            }

            return tires;
        }
    }
}
