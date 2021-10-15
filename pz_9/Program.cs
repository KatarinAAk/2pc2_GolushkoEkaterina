using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 0 до 10: ");
            int inputNum = int.Parse(Console.ReadLine());
            Random random = new Random();
            int sizeArray = random.Next(8, 20);
            int[,] array = new int[sizeArray, sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            int count = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    if (array[i, j] == inputNum) count++;
                }
            }
            Console.WriteLine("Таблица");
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Кол-во повторяющихся элементов " + inputNum + " равна " + count);
        }
    }
}
