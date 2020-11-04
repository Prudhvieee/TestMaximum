using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    /// <summary>
    /// checking for maximum value of input
    /// </summary>
    public class FindMaximumInteger
    {
        /// <summary>
        /// returns the maxmimum integer value of given numbers
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        /// <returns></returns>
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("all the numbers have same value");
        }
    }
}
