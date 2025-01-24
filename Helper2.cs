using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Classes
{
    internal class Helper2<T> /*where T : IComparable<T>*/
    {
        public static int SearchArr(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals(Arr[i]))
                    return i;
            }
            return -1;
        }

        //public static T Max(T num1 , T num2) 
        //{
        //    T Result = (num1.CompareTo(num2) >= 0) ? num1 : num2;
        //    return Result;
        //}

        public static void ReplaceArray(T[] Arr, T Value, T NewValue) 
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Arr[i].Equals(Value))
                    Arr[i] = NewValue;
            }
        }


    }
}
