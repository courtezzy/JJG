using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ArrayExtensions
    {
        public static double AverageArithmetic(this int[] array)
        {
            return array.Sum() / (double)array.Length;
        }
        public static double AverageGeometric(this int[] array)
        {
            double product = 1;
            foreach (int num in array)
            {
                product *= num;
            }
            return Math.Pow(product, 1.0 / array.Length);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            double averageArithmetic = array.AverageArithmetic();
            double averageGeometric = array.AverageGeometric();
            Console.WriteLine($"Average Arithmetic: {averageArithmetic}");
            Console.WriteLine($"Average Geometric: {averageGeometric}");
            Console.ReadLine();
        }
    }
}
