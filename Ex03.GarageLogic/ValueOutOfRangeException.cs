using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ValueOutOfRangeException : Exception
    {
        public readonly int r_MaxValue;
        public readonly int r_MinValue;
        public ValueOutOfRangeException(string i_message, int i_MinValue, int i_MaxValue)
            : base(i_message)
        {
            r_MaxValue = i_MaxValue;
            r_MinValue = i_MinValue;
        }
    }
}
