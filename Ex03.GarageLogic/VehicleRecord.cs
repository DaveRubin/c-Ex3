namespace Ex03.GarageLogic
{
    public class VehicleRecord
    {
        public Vehicle m_Vehicle;
        public VehicleOwner m_Owner;
        public Garage.eVehicleStatus m_Status;

        public VehicleRecord(Vehicle i_vehicle, VehicleOwner i_owner)
        {
            m_Vehicle = i_vehicle;
            m_Owner = i_owner;
            m_Status = Garage.eVehicleStatus.BeingFixed;
        }

        public void ChangeVehicleStatusTo(Garage.eVehicleStatus i_NewVehicleStatus)
        {
            m_Status = i_NewVehicleStatus;
        }
    }
}
