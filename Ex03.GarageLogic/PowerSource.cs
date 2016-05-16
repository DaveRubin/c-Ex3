namespace Ex03.GarageLogic
{
    // base class for other engine types
    public class PowerSource
    {
        public virtual float GetPercentageLeft
        {
            get
            {
                return 0;
            }
        }
    }
}
