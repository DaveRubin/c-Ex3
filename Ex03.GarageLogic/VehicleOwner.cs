using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleOwner
    {
        public readonly string r_Name;
        public readonly string r_PhoneNumber;

        internal VehicleOwner(string i_Name, string i_PhoneNumber)
        {
            r_Name = i_Name;
            r_PhoneNumber = i_PhoneNumber;
        }
    }
}
