using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Car : Vehicle
    {
        public readonly int r_doorsCount;
        public readonly eCarColor r_color;

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
            List<Wheel> i_wheels,
            eCarColor i_color,
            int i_doorsCount)
            : base(i_powerSource, i_modelName, i_licenseNumber, i_wheels)
        {
            r_color = i_color;
            r_doorsCount = i_doorsCount;
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
