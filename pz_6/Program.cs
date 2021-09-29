using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int k = 0, z = 1, i = 0;
            while (x >= z)
            {
                (k, z) = (z, k + z);
                i++;
            }
            if (x == k) Console.WriteLine(i);
            else Console.WriteLine(-1);
        }
    }
}
