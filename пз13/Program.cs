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
                case (Kate)1:
                    Console.WriteLine("Очень плохо!");
                    break;
                case (Kate)2:
                    Console.WriteLine("Плохо!");
                    break;
                case (Kate)3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case (Kate)4:
                    Console.WriteLine("Хорошо!");
                    break;
                case (Kate)5:
                    Console.WriteLine("Отлично");
                    break;
            }
        }
    }
}l

            
            


    

