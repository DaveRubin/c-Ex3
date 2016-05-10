using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class ExceptionMessages
    {
        //value out of range exceptions
        public static string k_ElectricPowerSourceExceedingMaximumHours = "Exceeded maximum hours allowed";
        public static string k_PetrolPowerSourceExceedingMaxFuelAllowed = "Exceeded maximum fuel allowed.";
        public static string k_TireExceededMaxAirPressure = "Exceeded maximum air pressure allowed.";

        //argument exception
        public static string k_FuelTypeMismatch = "Trying to fuel with mismatching type";
        public static string k_PetrolPowerSourceNonPositiveMaxFuel = "Non positive max fuel is'nt allowed.";
        public static string k_ElectricPowerSourceNonPositiveMaxHours = "Non positive max hours is'nt allowed.";
        public static string k_MotorcycleNonPositiveEngineVolumeValue = "Non positive engine volume is'nt allowed.";
        public static string k_CarInvalidDoorsCount = "Invalid doors count.";
        public static string k_TruckNonPositiveWeight = "Non positive maximum weight is'nt allowed.";
        public static string k_TireNonPositiveMaxAirPressure = "Non positive maximum air pressure is'nt allowed.";
    }
}
