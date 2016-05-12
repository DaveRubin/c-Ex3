using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class CarOwnerView
    {

        public static string GetVehicleOwnerView(VehicleRecord i_Record)
        {
            return string.Format(
                VehicleViewTextTemplates.k_OwnerVehicleViewTemplate,
                i_Record.m_Owner.r_Name,
                i_Record.m_Status);
        }
    }
}
