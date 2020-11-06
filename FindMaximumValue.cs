using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class FindMaximumValue
    {
        /// <summary>
        /// Generic class for finding maximum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenericMaximum<T> where T : IComparable
        {
            public T[] array;
            public GenericMaximum(T[] array)
            {
                this.array = array;
            }
            /// <summary>
            /// Sorts the specified values.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            /// <summary>
            /// Returns the maximum value
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T MaxValue(params T[] values)
            {
                T[] sortedArray = Sort(this.array);

                return sortedArray[sortedArray.Length - 1];
            }
            /// <summary>
            /// Prints the maximum value
            /// </summary>
            public void PrintMax()
            {
                var max = MaxValue(this.array);
                Console.WriteLine("The maximum value is: " + max);

            }
        }
    }
}
