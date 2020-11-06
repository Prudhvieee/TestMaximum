using System;

namespace TestMaximum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 5, 8, 10, 44, 16 };
            float[] floatArray = { 1.5f, 2.7f, 3.9f, 92.1f, 106.9f };
            string[] stringArray = { "Bad", "CAT", "Polo", "BMW" };
            new FindMaximumValue.GenericMaximum<int>(intArray).PrintMax();
            new FindMaximumValue.GenericMaximum<float>(floatArray).PrintMax();
            new FindMaximumValue.GenericMaximum<string>(stringArray).PrintMax();
        }
    }
}
