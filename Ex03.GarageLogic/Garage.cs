using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private static Dictionary<string, VehicleRecord> m_licenseToRecordDictionary =
            new Dictionary<string, VehicleRecord>();

        /// <summary>
        /// Insert new vehicle to garage
        /// in case of an existing vehicle, no new record will be created,
        /// and current vehicle state will be changed to InRepair
        /// </summary>
        /// <param name="i_vehicle"></param>
        /// <param name="i_owner"></param>
        /// <returns>true if a new record was created</returns>
        internal static bool InsertVehicleRecord(Vehicle i_vehicle, VehicleOwner i_owner)
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

        internal static void PrintLicensePlatesByStatus(eVehicleStatus i_vehicleStatusToDisplay)
        {
            
            foreach (KeyValuePair<string, VehicleRecord> entry in m_licenseToRecordDictionary)
            {
                VehicleRecord recordToCheck = entry.Value;
                if (recordToCheck.m_Status == i_vehicleStatusToDisplay)
                {
                    string plateNumber = recordToCheck.m_Vehicle.r_LicenseNumber;
                    Console.WriteLine(plateNumber);
                }
            }
        }

        internal static void ChangeVehicleStatusTo(VehicleRecord i_record, eVehicleStatus i_newVehicleStatus)
        {
            i_record.ChangeVehicleStatusTo(i_newVehicleStatus);
        }

        internal static void FillTiresToMax(Vehicle i_Vehicle)
        {
            foreach (Tire tire in i_Vehicle.m_Tires)
            {
                tire.InflateToMax();
            }
        }

        internal static bool FillGasTank(int i_LicensePlateNumber, PetrolPowerSource.eFuelType i_FuelType, float i_AmountToFill)
        {
            return false;
        }

        internal static bool FillBattery(int i_LicensePlateNumber, int i_MinutesToCharge)
        {
            return false;
        }

        internal static void PrintVehicleDetails(Vehicle i_Vehicle)
        {

        }

        public enum eVehicleStatus
        {
            BeingFixed,
            Fixed,
            PayedFor
        }
    }
}