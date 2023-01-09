using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Создаем лист интовых переменных
            List<int> intList = new List<int>();

            // Заполняем лист из калвиатуры
            Console.WriteLine("Введите элементы листа (разделяйте их пробелами):");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            foreach (string number in inputNumbers)
            {
                intList.Add(int.Parse(number));
            }

            // Выводим индексы переменных равных проверочным (введенным с клавиатуры)
            Console.WriteLine("Введите проверочное число:");
            int checkNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == checkNumber)
                {
                    Console.WriteLine("Индекс равного числа: " + i);
                }
            }

            // Копируем лист в массив
            int[] intArray = intList.ToArray();
            Console.ReadLine();
        }
    }
}
