using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TaskSessionAdv_1
{
    internal class Range<T> where T :IComparable,INumber<T>
    {
        public T MaxValue { get; set; }
        public T MinValue { get; set; }
        public Range(T maxvalue,T minvalue)
        {
            MaxValue = maxvalue;
            MinValue = minvalue;
        }
        public bool IsRange(T value)
        {
            return value.CompareTo(MaxValue) <= 0 && value.CompareTo(MinValue)>=0;
        }
        public T Lenth()
        {
            return MaxValue-MinValue;
        }
    }
}
