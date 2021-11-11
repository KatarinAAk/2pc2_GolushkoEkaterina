using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            float[][] arr = new float[10][];

            arr[0] = new float[rand.Next(8, 21)];
            arr[1] = new float[rand.Next(8, 21)];
            arr[2] = new float[rand.Next(8, 21)];
            arr[3] = new float[rand.Next(8, 21)];
            arr[4] = new float[rand.Next(8, 21)];
            arr[5] = new float[rand.Next(8, 21)];
            arr[6] = new float[rand.Next(8, 21)];
            arr[7] = new float[rand.Next(8, 21)];
            arr[8] = new float[rand.Next(8, 21)];
            arr[9] = new float[rand.Next(8, 21)];


            for (int y = 0; y < arr.Length; y++)
            {
                for (int x = 0; x < arr[y].Length; x++)
                {
                    arr[y][x] = Convert.ToChar(rand.Next(0, 21));
                }
            }
            Console.WriteLine("Ступенчатый массив");

            foreach (float[] row in arr)
            {
                foreach (float symbol in row)
                {
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();
            }

            float[] lastVals = new float[arr.Length];

            for (int i = 0; i < lastVals.Length; i++)
            {
                lastVals[i] = arr[i][^1];
            }

            Console.Write("\nПоследние элементы каждой строки: ");
            foreach (float ch in lastVals)
            {
                Console.Write($"{ch} ");
            }

            float[] maxVals = new float[arr.Length];
            for (int i = 0; i < maxVals.Length; i++)
            {
                float maxChar = arr[i][0];
                for (int k = 0; k < arr[i].Length; k++)
                {
                    if (arr[i][k] > maxChar)
                        maxChar = arr[i][k];
                }
                maxVals[i] = maxChar;
            }

            Console.Write("\nСтаршие элементы обновленного массива : ");
            foreach (float ch in maxVals)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i][Array.IndexOf(arr[i], maxVals[i])] = arr[i][0];
                arr[i][0] = maxVals[i];
            }

            Console.WriteLine("\nОбновлённый массив");
            foreach (float[] row in arr)
            {
                foreach (float ch in row)
                {
                    Console.Write($"{ch} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
