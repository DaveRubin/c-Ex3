using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        public static readonly List<int> sr_ValidVehicleDoorsList = new List<int>() { 2, 3, 4, 5 };

        public readonly int r_DoorsCount;
        public readonly eCarColor r_Color;

        /// <summary>
        /// Create a new car
        /// </summary>
        /// <param name="i_powerSource"></param>
        /// <param name="i_modelName"></param>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_wheels"></param>
        /// <param name="i_color"></param>
        /// <param name="i_doorsCount"></param>
        public Car(
            PowerSource i_powerSource,
            string i_modelName,
            string i_licenseNumber,
            List<Tire> i_wheels,
            eCarColor i_color,
            int i_doorsCount)
            : base(i_powerSource, i_modelName, i_licenseNumber, i_wheels)
        {
            if (!ValidateDoorsCount(i_doorsCount))
            {
                throw new ArgumentException(ExceptionMessages.k_CarInvalidDoorsCount, "i_doorsCount");
            }

            r_Color = i_color;
            r_DoorsCount = i_doorsCount;
        }

        private bool ValidateDoorsCount(int i_doorsCount)
        {
            return sr_ValidVehicleDoorsList.IndexOf(i_doorsCount) != -1;
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
