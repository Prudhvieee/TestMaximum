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
        }
    }
}
