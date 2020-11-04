using System;

namespace TestMaximum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum value");
            int intOutput = FindMaximumInteger.MaximumIntegerNumber(10,100,1000);
            Console.WriteLine($"Maximum integer value is {intOutput}");
            float floatOutput = FindMaximumFloat.MaximumFloatNumber(1.1f,2.1f,3.1f);
            Console.WriteLine($"Maximum float value is {floatOutput}");
            string stringOutput = FindMaximumString.MaximumOfGivenStrings("Apple", "bananna", "Peach");
            Console.WriteLine("maximum String is: " + stringOutput);
        }
    }
}
