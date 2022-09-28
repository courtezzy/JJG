using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("a= ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            c = Int32.Parse(Console.ReadLine());
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
    }
}
