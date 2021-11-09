using System;

namespace пз11голушко2пк2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            Console.Write("Введите число:");
            int N = int.Parse(Console.ReadLine());
            string str = "";
            foreach (char i in S)
            {
                str += new string('*', N) + i;
            }
            str += new string('*', N);
            Console.WriteLine(str);

        }
    }
}
