using System;
using System.IO;
using System.Linq;

namespace pz_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pathToInput = @"C:\Users\1073\Desktop\input.txt";
            string pathToOutput = @"C:\Users\1073\Desktop\output.txt";
            int[] nums = new int[100];
            File.Delete(pathToInput);

            using (StreamWriter sw = File.AppendText(pathToInput))
            {
                Random rand = new Random();
                for (int i = 0; i < 100; i++)
                {
                    nums[i] = rand.Next(0, 101);
                    sw.WriteLine(nums[i]);
                }
                Console.WriteLine();//числа сгенерированы в input.txt
            }
            var a = nums.Max();
            var b = nums.Min();
            using (StreamWriter sw = File.AppendText(pathToOutput))
            {
                sw.WriteLine(b);
                sw.WriteLine(a);
            }
            Console.WriteLine($"Max({a}) Min({b})");//в output.txt показаны max and min числа
        }
    }
}