using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            for (int i = 20; i <= 90; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 2");
            for (int i = 0; i < 6; i += 1)
            {
                Console.Write($"{(char)(i + 'h')}\t");//Преобразование числа в символ
            }
            Console.WriteLine("Задание 3");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(new string('#', 6));
            }
            Console.WriteLine("Задание 4");
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 5");
            for (int i = 4, j = 40; ; i++, j--)
            {
                Console.WriteLine($"i={i} j={j} разница {j - i}");
                if (Math.Abs (j - i) == 13) break;
            }
        }
    }
}
