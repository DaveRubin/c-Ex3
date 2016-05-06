using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    //base class for other engine types
    class PowerSource
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
