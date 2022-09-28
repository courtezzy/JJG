using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    internal class Program
    {
        static void Remove(ref int[] arr, int i, int count)
        {
            for (int k = 0; k < count; k++)
            {
                RemoveAtFromArray(ref arr, i);
            }


        }
        static void RemoveAtFromArray(ref int[] arr, int index)
        {
            int[] newArray = new int[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
        }
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[]
            {
                2,2,
                3,3,3,3,
                4,4,
                5,5,5,
                6,6,6
            };
            Console.WriteLine("Select option:\n" +
                "1. k<length of series\n" +
                "2. k>lenght of series\n" +
                "3. k=length of series\n");
            int option = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int k = Int32.Parse(Console.ReadLine());
            int series = 1;
            int i = 0;
            for (i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    series++;
                }

            }
            int[] arrLength = new int[series];
            i = 0;
            for (int j = 0; j < arrLength.Length; j++)
            {
                if (i == array.Length - 1)
                {
                    break;
                }
                int length = 1;
                while (array[i] == array[i + 1])
                {

                    length++;
                    i++;
                    if (i == array.Length - 1)
                    {
                        break;
                    }
                }
                arrLength[j] = length;
                i++;
            }
            i = 0;
            int dlina = array.Length;
            for (int j = 0; j < arrLength.Length; j++)
            {
                Console.WriteLine(arrLength[j]);
                if (option == 1)
                {
                    if (arrLength[j] > k)
                    {
                        if (j == 0)
                        {
                            Remove(ref array, 0, arrLength[j]);
                            continue;
                        }
                        if (array.Length != dlina)
                        {
                            int temp = dlina - array.Length;
                            for (int t = 0; t < j; t++)
                            {
                                i += arrLength[t];
                            }
                            i = i - temp;
                        }
                        else
                        {
                            for (int t = 0; t < j; t++)
                            {
                                i += arrLength[t];
                            }
                        }
                        Remove(ref array, i, arrLength[j]);
                        i = 0;

                    }
                }
                if (option == 2)
                {
                    if (arrLength[j] > k)
                    {
                        if (j == 0)
                        {
                            Remove(ref array, 0, arrLength[j]);
                            continue;
                        }
                        if (array.Length != dlina)
                        {
                            int temp = dlina - array.Length;
                            for (int t = 0; t < j; t++)
                            {
                                i += arrLength[t];
                            }
                            i = i - temp;
                        }
                        else
                        {
                            for (int t = 0; t < j; t++)
                            {
                                i += arrLength[t];
                            }
                        }
                        Remove(ref array, i, arrLength[j]);
                        i = 0;

                    }
                }
                if (option == 3)
                {
                    if (arrLength[j] == k)
                    {
                        if (j == 0)
                        {
                            Remove(ref array, 0, arrLength[j]);
                            continue;
                        }
                        if (array.Length != dlina)
                        {
                            int temp = dlina - array.Length;
                            for (int t = 0; t < j; t++)
                            {
                                i += arrLength[t];
                            }
                            i = i - temp;
                        }
                        else
                        {
                            for (int t = 0; t < j; t++)
                            {
                                i += arrLength[t];
                            }
                        }
                        Remove(ref array, i, arrLength[j]);
                        i = 0;

                    }
                }
            }
                    foreach (var item in arrLength)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    foreach (var item in array)
                    {
                        Console.Write($"{item}\t");

                    }
                    Console.ReadLine();
        }
    }
}
