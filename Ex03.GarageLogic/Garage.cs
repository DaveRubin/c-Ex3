using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private static Dictionary<string, VehicleRecord> m_licenseToRecordDictionary =
            new Dictionary<string, VehicleRecord>();

        public static bool IsVehicleExist(string i_LisenceNumber)
        {
            return m_licenseToRecordDictionary.ContainsKey(i_LisenceNumber);
        }

        /// <summary>
        /// Insert new vehicle to garage
        /// in case of an existing vehicle, no new record will be created,
        /// and current vehicle state will be changed to InRepair
        /// </summary>
        /// <param name="i_Vehicle"></param>
        /// <param name="i_Owner"></param>
        /// <returns>true if a new record was created</returns>
        public static bool InsertVehicleRecord(Vehicle i_Vehicle, VehicleOwner i_Owner)
        {
            bool res = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_Vehicle.r_LicenseNumber))
            {
                VehicleRecord recordToAlter = m_licenseToRecordDictionary[i_Vehicle.r_LicenseNumber];
                recordToAlter.ChangeVehicleStatusTo(eVehicleStatus.BeingFixed);
            }
            else
            {
                VehicleRecord record = new VehicleRecord(i_Vehicle, i_Owner);
                m_licenseToRecordDictionary.Add(i_Vehicle.r_LicenseNumber, record);
                res = true;
            }

            return res;
        }

        public static VehicleRecord GetRecordByPlateNumber(string i_PlateNumberRequested)
        {
            return m_licenseToRecordDictionary[i_PlateNumberRequested];
        }

        /// <summary>
        /// Get all license numbers for vehicles that match certain status
        /// </summary>
        /// <param name="i_VehicleStatusToDisplay"></param>
        /// <returns></returns>
        public static List<string> GetLicensePlatesByStatus(eVehicleStatus i_VehicleStatusToDisplay)
        {
            List<string> matchingLicenseNumbers = new List<string>();

            foreach (KeyValuePair<string, VehicleRecord> entry in m_licenseToRecordDictionary)
            {
                VehicleRecord recordToCheck = entry.Value;
                if (recordToCheck.m_Status == i_VehicleStatusToDisplay)
                {
                    matchingLicenseNumbers.Add(recordToCheck.m_Vehicle.r_LicenseNumber);
                }
            }

            return matchingLicenseNumbers;
        }

        /// <summary>
        /// change record status by its vehicle license number
        /// return true if found & changed status
        /// </summary>
        /// <param name="i_LicenseNumber"></param>
        /// <param name="i_NewVehicleStatus"></param>
        public static bool ChangeVehicleStatusTo(string i_LicenseNumber, eVehicleStatus i_NewVehicleStatus)
        {
            bool isFoundAndChanged = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_LicenseNumber))
            {
                VehicleRecord record = m_licenseToRecordDictionary[i_LicenseNumber];
                record.ChangeVehicleStatusTo(i_NewVehicleStatus);
                isFoundAndChanged = true;
            }

            return isFoundAndChanged;
        }

        /// <summary>
        /// Inflate all tires in a vehicle by its license number
        /// returns true if successfull 
        /// </summary>
        /// <param name="i_LicenseNumber"></param>
        public static bool FillTiresToMax(string i_LicenseNumber)
        {
            bool isSuccess = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_LicenseNumber))
            {
                Vehicle vehicle = m_licenseToRecordDictionary[i_LicenseNumber].m_Vehicle;

                foreach (Tire tire in vehicle.m_Tires)
                {
                    tire.InflateToMax();
                }

                isSuccess = true;
            }

            return isSuccess;
        }

        /// <summary>
        /// Fill gas tank returns true if found & filled
        /// </summary>
        /// <param name="i_LicensePlateNumber"></param>
        /// <param name="i_FuelType"></param>
        /// <param name="i_AmountToFill"></param>
        /// <returns></returns>
        public static bool FillGasTank(
            string i_LicensePlateNumber,
            PetrolPowerSource.eFuelType i_FuelType,
            float i_AmountToFill)
        {
            bool isSuccess = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_LicensePlateNumber))
            {
                Vehicle vehicle = m_licenseToRecordDictionary[i_LicensePlateNumber].m_Vehicle;

                // check if vehicle is petrol source
                if (vehicle.r_PowerSource.GetType() != typeof(PetrolPowerSource))
                {
                    throw new ArgumentException(ExceptionMessages.k_GarageTryingToFillGasTankForElectric);
                }

                ((PetrolPowerSource)vehicle.r_PowerSource).Fuel(i_FuelType, i_AmountToFill);
                isSuccess = true;
            }

            return isSuccess;
        }

        /// <summary>
        /// Charge vehicle battery
        /// </summary>
        /// <param name="i_LicensePlateNumber"></param>
        /// <param name="i_MinutesToCharge"></param>
        /// <returns></returns>
        public static bool FillBattery(string i_LicensePlateNumber, int i_MinutesToCharge)
        {
            bool isSuccess = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_LicensePlateNumber))
            {
                Vehicle vehicle = m_licenseToRecordDictionary[i_LicensePlateNumber].m_Vehicle;

                // check if vehicle is petrol source
                if (vehicle.r_PowerSource.GetType() != typeof(ElectricPowerSource))
                {
                    throw new ArgumentException(ExceptionMessages.k_GarageTryingToChargePetrolVehicle);
                }

                float hoursToCharge = (float)i_MinutesToCharge / 60;
                ((ElectricPowerSource)vehicle.r_PowerSource).Charge(hoursToCharge);

                isSuccess = true;
            }

            return isSuccess;
        }

        /// <summary>
        /// Get the Vehicle record
        /// </summary>
        /// <param name="i_LicenseNumber"></param>
        /// <returns></returns>
        public static VehicleRecord GetVehicleDetails(string i_LicenseNumber)
        {
            return m_licenseToRecordDictionary[i_LicenseNumber];
        }

        public enum eVehicleStatus
        {
            BeingFixed,
            Fixed,
            PayedFor
        }
    }
}