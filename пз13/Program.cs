using System;

namespace пз13
{
    class Program
    {
        enum Kate
        {
            Verybad = 1,
            Bad = 2,
            Normal = 3,
            Good = 4,
            VeryGood = 5

        }
        static void Main(string[] args)
        {
            Kate katarin = new Kate();
            Console.WriteLine("Введите строку:");
            string цветочек = Console.ReadLine();
            Enum.TryParse(цветочек, out katarin);
            switch (katarin)
            {
                case Kate.Verybad:
                    Console.WriteLine("1");
                    break;
                case Kate.Bad:
                    Console.WriteLine("2");
                    break;
                case Kate.Normal:
                    Console.WriteLine("3");
                    break;
                case Kate.Good:
                    Console.WriteLine("4");
                    break;
                case Kate.VeryGood:
                    Console.WriteLine("5");
                    break;
            }
        }
    }
}

            
            


    

