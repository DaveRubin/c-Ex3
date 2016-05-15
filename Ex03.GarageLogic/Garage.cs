using System;
using System.Collections.Generic;
using System.Text;

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
        /// <param name="i_vehicle"></param>
        /// <param name="i_owner"></param>
        /// <returns>true if a new record was created</returns>
        public static bool InsertVehicleRecord(Vehicle i_vehicle, VehicleOwner i_owner)
        {
            bool res = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_vehicle.r_LicenseNumber))
            {
                VehicleRecord recordToAlter = m_licenseToRecordDictionary[i_vehicle.r_LicenseNumber];
                recordToAlter.ChangeVehicleStatusTo(eVehicleStatus.BeingFixed);
            }
            else
            {
                VehicleRecord record = new VehicleRecord(i_vehicle, i_owner);
                m_licenseToRecordDictionary.Add(i_vehicle.r_LicenseNumber,record);
                res = true;
            }
            
            return res;
        }

        public static VehicleRecord GetRecordByPlateNumber(string i_plateNumberRequested)
        {
            return m_licenseToRecordDictionary[i_plateNumberRequested];
        }
        /// <summary>
        /// Get all license numbers for vehicles that match certain status
        /// </summary>
        /// <param name="i_vehicleStatusToDisplay"></param>
        /// <returns></returns>
        public static List<string> GetLicensePlatesByStatus(eVehicleStatus i_vehicleStatusToDisplay)
        {
            List<string> matchingLicenseNumbers = new List<string>();

            foreach (KeyValuePair<string, VehicleRecord> entry in m_licenseToRecordDictionary)
            {
                VehicleRecord recordToCheck = entry.Value;
                if (recordToCheck.m_Status == i_vehicleStatusToDisplay)
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
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_newVehicleStatus"></param>
        public static bool ChangeVehicleStatusTo(string i_licenseNumber, eVehicleStatus i_newVehicleStatus)
        {
            bool isFoundAndChanged = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_licenseNumber))
            {
                VehicleRecord record = m_licenseToRecordDictionary[i_licenseNumber];
                record.ChangeVehicleStatusTo(i_newVehicleStatus);
                isFoundAndChanged = true;
            }

            return isFoundAndChanged;
        }

        /// <summary>
        /// Inflate all tires in a vehicle by its license number
        /// returns true if successfull 
        /// </summary>
        /// <param name="i_licenseNumber"></param>
        public static bool FillTiresToMax(string i_licenseNumber)
        {
            bool isSuccess = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_licenseNumber))
            {
                Vehicle vehicle = m_licenseToRecordDictionary[i_licenseNumber].m_Vehicle;

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
        public static bool FillGasTank(string i_LicensePlateNumber, PetrolPowerSource.eFuelType i_FuelType, float i_AmountToFill)
        {
            bool isSuccess = false;

            if (m_licenseToRecordDictionary.ContainsKey(i_LicensePlateNumber))
            {
                Vehicle vehicle = m_licenseToRecordDictionary[i_LicensePlateNumber].m_Vehicle;

                //check if vehicle is petrol source
                if (vehicle.r_PowerSource.GetType() != typeof(PetrolPowerSource))
                {
                    throw new ArgumentException(ExceptionMessages.k_GarageTryingToFillGasTankForElectric);
                }

                ((PetrolPowerSource)vehicle.r_PowerSource).Fuel(i_FuelType,i_AmountToFill);
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

                //check if vehicle is petrol source
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