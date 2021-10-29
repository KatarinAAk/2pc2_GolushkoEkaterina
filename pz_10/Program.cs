using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            //Пункт 1
            int[][] list = new int[10][];//Создаём массив
            //Заполняем массив
            for (int i = 0; i < 10; i++)
            {
                list[i] = new int[rd.Next(8, 20)];
                for (int y = 0; y < list[i].Length; y++)
                {
                    list[i][y] = rd.Next(0, 100);
                }
            }
            //Пункт 2
            //Выводим массив
            Console.WriteLine("Массив:");
            foreach (int[] i in list)
            {
                foreach (int y in i) Console.Write(y + "\t");
                Console.WriteLine();
            }
            //Пункт 3
            //Находим последние значения
            int[] values = new int[10];
            for (int i = 0; i < 10; i++)
            {
                values[i] = list[i][list[i].Length - 1];
            }
            //Выводим массив
            Console.WriteLine("Последние значения:");
            foreach (int i in values)
            {
                Console.Write(i + "\t");

            }
            Console.WriteLine();
            //Пункт 4
            //Находим максимальные значения
            for (int i = 0; i < 10; i++)
            {
                values[i] = list[i].Max();
            }
            //Выводим значения
            Console.WriteLine("Максимальные значения:");
            foreach (int i in values)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //Пункт 5
            //Меняем местами значения
            for (int i = 0; i < 10; i++)
            {
                int position = Array.IndexOf(list[i], values[i]);
                list[i][position] = list[i][0];
                list[i][0] = values[i];
            }
            Console.WriteLine("Массив:");
            foreach (int[] i in list)
            {
                foreach (int y in i) Console.Write(y + "\t");
                Console.WriteLine();
            }
        }
    }
}
