using System;
using System.Collections.Generic;
namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] arrayInt = new int[20];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = rand.Next(0, 10);
            }

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (dict.ContainsKey(arrayInt[i]))
                {
                    dict[arrayInt[i]]++;
                }
                else
                {
                    dict.Add(arrayInt[i], 1);
                }
            }
            Console.Write("Массив равен: ");
            foreach (int i in arrayInt)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, int> keyValue in dict)
            {
                Console.WriteLine($"Число {keyValue.Key} повторяется {keyValue.Value} раз(-а)");
            }
        }
    }
}
