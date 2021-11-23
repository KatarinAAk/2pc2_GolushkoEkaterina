using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = @"C:\Users\golushko\Desktop\999.txt";
            string str;

            Console.Write("Введите число:");
            int num = int.Parse(Console.ReadLine());

            FileStream file = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);

            for (int i = 0; i < num; i++)
            {
                str = new string('*', i);
                writer.WriteLine(str);
            }
            writer.Close();
        }
    }
}
