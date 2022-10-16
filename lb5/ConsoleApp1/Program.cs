using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       static int Max(int[,] arr, int m, int n)
        {
            int max = arr[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(max<arr[i, j])
                    {
                        max = arr[i, j];
                    }

                }

            }
            return max;
        }
        static int Min(int[,] arr, int m, int n)
        {
            int min = arr[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }

                }

            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Random rand = new Random();
            int m = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());
            int[,] nums1 = new int[m,n];
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    nums1[i, j] = rand.Next(0,11);
                
                }
           
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{nums1[i, j]}\t");

                }
                Console.WriteLine();
            }
            int min = Min(nums1, m, n);
            Console.WriteLine("Місце мінімального елементу: ");
            bool isAlready = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums1[i, j] == min && isAlready == false)
                    {
                        Console.WriteLine($"Номер ряду:{i+1}");
                        Console.WriteLine($"Номер стовпчику:{j+1}");
                        isAlready = true;
                    }

                }

            }
            int max = Max(nums1, m, n);
            Console.WriteLine("Місце максимального елементу: ");
            isAlready = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums1[i, j] == max && isAlready == false)
                    {
                        Console.WriteLine($"Номер ряду:{i+1}");
                        Console.WriteLine($"Номер стовпчику:{j+1}");
                        isAlready = true;
                    }

                }

            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.ReadLine();
        }
    }
}
