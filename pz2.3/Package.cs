using System;
using System.Collections.Generic;
using System.Text;

namespace pz2._3
{
    class Package
    {
        private string nameDest;
        private string nameSor;
        private string addres;
        private string type;
        private string receiptDate;
        private int Weight;
        private Random rnd = new Random();
        static int Packagee;
        static int Weightt;

        
        public Package(string _nameDest, string _nameSor, string _addres, string _type, int _Weight)
        {
            nameDest = _nameDest;
            nameSor = _nameSor;
            addres = _addres;
            type = _type;
            if (Weight >= 0.01 && Weight <= 10)
                Weight = _Weight;
            else
                Weight = rnd.Next((int)0.01, 10);
            receiptDate = DateTime.Now.ToString();
            Packagee++;
            Weightt += Weight;
        }
      
        public Package(string _nameDest, string _nameSor, string _addres, string _type)
        {
            nameDest = _nameDest;
            nameSor = _nameSor;
            addres = _addres;
            type = _type;
            Weight = rnd.Next((int)0.01, 10);
            receiptDate = DateTime.Now.ToString();
            Packagee++;
            Weightt += Weight;
        }
        public static int GetPackagee() 
        {
            return Packagee;
        }
        public static int GetWeightt()
        {
            return Weightt;
        }
        public void GetPackageInfo()
        {
            Console.WriteLine($"Всего посылок: {Package.GetPackagee()}" + $"\nОбщий вес посылок: {Package.GetWeightt()}");
            Console.WriteLine($"nameDest = {nameDest}, nameSor = {nameSor}, addres = {addres}, receiptDate = {receiptDate}, type = {type}, Weight={Weight}");
          
        }
    }
}
