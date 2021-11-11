using System;

namespace pz12golushko2pk2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToUpper();
            string[] array = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string i in array)
            {
                if (i[0] == 'О') count++;
            }
            Console.WriteLine(count);
        }
    }
}
