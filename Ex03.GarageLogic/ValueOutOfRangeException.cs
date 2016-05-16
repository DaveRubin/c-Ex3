using System;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        public readonly int r_MaxValue;
        public readonly int r_MinValue;

        public ValueOutOfRangeException(string i_Message, int i_MinValue, int i_MaxValue)
            : base(i_Message)
        {
            r_MaxValue = i_MaxValue;
            r_MinValue = i_MinValue;
        }
    }
}
