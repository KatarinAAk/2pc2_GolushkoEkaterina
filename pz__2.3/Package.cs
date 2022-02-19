using System;
using System.Collections.Generic;
using System.Text;

namespace pz__2._3
{
    class Package
    {
        private string nameDest;
        private string nameSor;
        private string addres;
        private string type;
        private string receiptDate;
        private Random rnd = new Random()

        public Package(string _nameDest, string _nameSor, string _addres, string _type)
        {
            nameDest = _nameDest;
            nameSor= _nameSor;
            addres = _addres;
            type = _type;
            receiptDate = DateTime.Now.ToString();
        }

        public void GetPackageInfo()
        {
            Console.WriteLine($"nameDest = {nameDest}, nameSor = {nameSor}, addres = {addres}, receiptDate = {receiptDate}, type = {type}");
        }
    }
}
