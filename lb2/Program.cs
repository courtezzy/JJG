using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nn:");
            int nn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter nk:");
            int nk = Int32.Parse(Console.ReadLine());
            if (nk >= nn && nn >= 0)
            {
                int k = nn;
                double result = 1.0;


                while (k <= nk)
                {
                    result *= (Math.Pow(-1, Math.Pow(k, 2) - 2 * k + 3) * k + 1) / Math.Pow(k, 2) - 2;
                    k++;
                }



                Console.WriteLine($"result: {result}");
                Console.ReadLine();
            }
        }
    }
}
