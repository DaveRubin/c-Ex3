﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class CarOwnerView
    {


        /// <summary>
        /// Create a new owner creation dialog
        /// </summary>
        /// <returns></returns>
        public static VehicleOwner GetNewOwnerDialog()
        {
            Console.WriteLine(GarageSystemText.k_VehicleRecordGetOwnerName);
            string ownerName = Console.ReadLine();
            Console.WriteLine(GarageSystemText.k_VehicleRecordGetOwnerPhoneNumber);
            string ownerPhoneNumber = Console.ReadLine();
            return new VehicleOwner(ownerName, ownerPhoneNumber);
        }

        public static string GetVehicleOwnerView(VehicleRecord i_Record)
        {
            return string.Format(
                VehicleViewTextTemplates.k_OwnerVehicleViewTemplate,
                i_Record.m_Owner.r_Name,
                i_Record.m_Status);
        }
    }
}
