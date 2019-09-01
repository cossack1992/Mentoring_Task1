using System;
using System.Collections.Generic;
using System.Text;

namespace PerformensCheck
{
    public struct ValueType
    {
        private readonly int _value1;
        private readonly int _value2;
        private readonly int _value3;
        private readonly int _value4;

        public ValueType(int value1, int value2, int value3, int value4)
        {
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
        }
    }
}
