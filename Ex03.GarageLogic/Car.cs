using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Car : Vehicle
    {
        public static readonly List<int> sr_ValidVehicleDoorsList = new List<int>() { 2, 3, 4, 5 };

        public readonly int r_DoorsCount;
        public readonly eCarColor r_Color;

        /// <summary>
        /// Create a new car
        /// </summary>
        /// <param name="i_PowerSource"></param>
        /// <param name="i_ModelName"></param>
        /// <param name="i_LicenseNumber"></param>
        /// <param name="i_Tires"></param>
        /// <param name="i_Color"></param>
        /// <param name="i_DoorsCount"></param>
        protected Car(
            PowerSource i_PowerSource,
            string i_ModelName,
            string i_LicenseNumber,
            List<Tire> i_Tires,
            eCarColor i_Color,
            int i_DoorsCount)
            : base(i_PowerSource, i_ModelName, i_LicenseNumber, i_Tires)
        {
            if (!ValidateDoorsCount(i_DoorsCount))
            {
                throw new ArgumentException(ExceptionMessages.k_CarInvalidDoorsCount, "i_DoorsCount");
            }

            r_Color = i_Color;
            r_DoorsCount = i_DoorsCount;
        }

        private bool ValidateDoorsCount(int i_DoorsCount)
        {
            return sr_ValidVehicleDoorsList.IndexOf(i_DoorsCount) != -1;
        }

        public enum eCarColor
        {
            Yellow,
            White,
            Red,
            Black
        }
    }
}
