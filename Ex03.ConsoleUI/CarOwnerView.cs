using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    class CarOwnerView
    {
        private const string k_OwnerVehicleViewTemplate = @"Owner name: {0}
Vehicle status: {1}";

        public static string GetVehicleOwnerView(VehicleRecord i_Record)
        {
            return string.Format(k_OwnerVehicleViewTemplate, i_Record.m_Owner.r_Name, i_Record.m_Status);
        }
    }
}
