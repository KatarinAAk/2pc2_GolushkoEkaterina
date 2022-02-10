using System;

namespace pz__2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Package p1 = new Package("Вика", "Рэм", "г.Екатеренбург", "Подарок");
            Package p2 = new Package("Арсений", "Тамара", "г.Тамбов", "Деньги");
            Package p3 = new Package("Лев", "Люда", "г.Оренбург", "Письмо");
            Package p4 = new Package("Катарина", "Анна", "г.Москва", "Деньги");

            p1.GetPackageInfo();
            p2.GetPackageInfo();
            p3.GetPackageInfo();
            p4.GetPackageInfo();
        }
    }
}
