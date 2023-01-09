using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static char[] ToMyCharArray<T>(T value)
        {
            string str = value.ToString();
            return str.ToCharArray();
        }
        static void Main(string[] args)
        {
            string testStr = "string";
            int testInt = 12345;
            double testDouble = 729.729;
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine($"Перевертаємо рядок: {testStr}");
            Console.WriteLine(Revert(testStr));
            Console.WriteLine("**************");
            Console.WriteLine($"Перевертаємо ціле число: {testInt}");
            Console.WriteLine(Revert(testInt));
            Console.WriteLine("**************");
            Console.WriteLine($"Перевертаємо дробове число: {testDouble}");
            Console.WriteLine(Revert(testDouble));
            Console.WriteLine("**************");
            Console.WriteLine("Перевертаємо масив: ");
            foreach (var item in myArr)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();
            ArrayRevert<int>(ref myArr, out myArr);
            Console.WriteLine("Перевернутий масив: ");
            foreach (var item in myArr)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine("Магічний сепаратор: ");
            Console.WriteLine(RevertWithMagicSeparator("123", '/'));
            Console.ReadLine();
        }

        public static string Revert(string str)//перевертаємо строку
        {
            char[] arr = ToMyCharArray<string>(str);
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int Revert(int number)//перевертаємо ціле число
        {
            char[] arr = ToMyCharArray<int>(number);
            Array.Reverse(arr);
            string str = new string(arr);
            return Int32.Parse(str);
        }

        public static double Revert(double number)//перевертаємо дробове число
        {
            string str = number.ToString();
            string[] arr = str.Split(',');
            if (arr.Length == 2)
            {
                char[] intPartArr = arr[0].ToCharArray();
                char[] doublePartArr = arr[1].ToCharArray();
                Array.Reverse(intPartArr);
                Array.Reverse(doublePartArr);
                char[] concateArr = intPartArr.Concat(doublePartArr).ToArray();
                char lastIntSymbol = intPartArr[intPartArr.Length - 1];
                char[] resultArr = new char[concateArr.Length + 1];
                bool separatorInserted = false;
                for (int i = 0; i < concateArr.Length; i++)
                {
                    if (!separatorInserted)
                    {
                        resultArr[i] = concateArr[i];
                        if (resultArr[i] == lastIntSymbol)
                        {
                            resultArr[i + 1] = ',';
                            separatorInserted = true;
                        }
                    }
                    else
                    {
                        resultArr[i + 1] = concateArr[i];
                    }
                }
                return double.Parse(new string(resultArr));
            }
            else
            {
                return Revert((int)number);
            }
        }
        public static string RevertWithMagicSeparator(string numberStr, char magicSeparator)
        {
            string[] arr = numberStr.Split(magicSeparator);
            if (arr.Length == 2)
            {
                char[] intPartArr = arr[0].ToCharArray();
                char[] doublePartArr = arr[1].ToCharArray();
                Array.Reverse(intPartArr);
                Array.Reverse(doublePartArr);
                char[] concateArr = intPartArr.Concat(doublePartArr).ToArray();
                char lastIntSymbol = intPartArr[intPartArr.Length - 1];
                char[] resultArr = new char[concateArr.Length + 1];
                bool separatorInserted = false;
                for (int i = 0; i < concateArr.Length; i++)
                {
                    if (!separatorInserted)
                    {
                        resultArr[i] = concateArr[i];
                        if (resultArr[i] == lastIntSymbol)
                        {
                            resultArr[i + 1] = magicSeparator;
                            separatorInserted = true;
                        }
                    }
                    else
                    {
                        resultArr[i + 1] = concateArr[i];
                    }
                }
                return new string(resultArr);
            }
            else
            {
                Array.Reverse(arr);
                return new string(arr[0]);
            }
        }
        public static void ArrayRevert<T>(ref T[] arr, out T[] resultArr)
        {
            int n = arr.Length;
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                T temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            resultArr = arr;
        }
    }
}