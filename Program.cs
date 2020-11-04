using System;

namespace TestMaximum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum value");
            int intOutput = new FindMaximumValue.GenricMaximum<int>(10,100,1000).MaxMethod();
            Console.WriteLine($"Maximum integer value is {intOutput}");
            float floatOutput = new FindMaximumValue.GenricMaximum<float>(1.1f,2.1f,3.1f).MaxMethod();
            Console.WriteLine($"Maximum float value is {floatOutput}");
            string stringOutput = new FindMaximumValue.GenricMaximum<string>("Apple", "bananna", "Peach").MaxMethod();
            Console.WriteLine("maximum String is: " + stringOutput);
        }
    }
}
