using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class Vehicle
    {
        private PowerSource m_PowerSource;
        private string m_ModelName;
        private string m_LicensePlateNumber;
        internal List<Tire> m_Tires;

        public float GetSourceEnergyPercentage
        {
            get
            {
                return m_PowerSource.GetPercentageLeft;
            }
        }

        public string GetLicensePlateNumber
        {
            get
            {
                return m_LicensePlateNumber;
            }
        }

        public Vehicle()
        {
            
        }

        public override string ToString()
        {
            /// TODO: implement override that iterates through all of the data members and prints them out
            /// as Guy shows in the overriding object methods video
            return string.Format("...");
        }
    }
}
