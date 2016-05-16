using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class VehicleOwnerView
    {


        public static string GetVehicleOwnerView(VehicleRecord i_Record)
        {
            return string.Format(
                GarageSystemText.k_OwnerVehicleViewTemplate,
                i_Record.m_Owner.r_Name,
                i_Record.m_Status);
        }

        public static void PrintVehicleRecordGetOwnerName()
        {
            Console.WriteLine(GarageSystemText.k_VehicleRecordGetOwnerName);
        }

        public static void VehicleRecordGetOwnerPhoneNumber()
        {
            Console.WriteLine(GarageSystemText.k_VehicleRecordGetOwnerPhoneNumber);
        }
    }
}
