using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        static internal List<VehicleRecord> m_VehicleRecords;

        static internal bool InsertVehicleRecord(Vehicle i_vehicle, VehicleOwner i_owner)
        {
            //TODO: wrap in try & catch 
            bool res = false;
            VehicleRecord record = new VehicleRecord(i_vehicle, i_owner);
            m_VehicleRecords.Add(record);
            return res;
        }

        static internal void PrintLicensePlatesByStatus(eVehicleStatus i_vehicleStatusToDisplay)
        {
            foreach (VehicleRecord record in m_VehicleRecords)
            {
                if (record.m_Status == i_vehicleStatusToDisplay)
                {
                    string plateNumber = record.m_Vehicle.r_LicenseNumber;
                    Console.WriteLine(plateNumber);
                }
            }
        }

        static internal void ChangeVehicleStatusTo(VehicleRecord i_record, eVehicleStatus i_newVehicleStatus)
        {
            i_record.ChangeVehicleStatusTo(i_newVehicleStatus);
        }

        static internal void FillTiresToMax(Vehicle i_Vehicle)
        {
            foreach (Tire tire in i_Vehicle.m_Tires)
            {
                tire.InflateToMax();
            }
        }

        static internal bool FillGasTank(int i_LicensePlateNumber, PetrolPowerSource.eFuelType i_FuelType, float i_AmountToFill)
        {
            return false;
        }

        static internal bool FillBattery(int i_LicensePlateNumber, int i_MinutesToCharge)
        {
            return false;
        }

        static internal void PrintVehicleDetails(Vehicle i_Vehicle)
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