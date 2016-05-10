using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ValueOutOfRangeException : Exception
    {
        public ValueOutOfRangeException(string i_message)
            : base(i_message)
        {
            
        }
    }
}
