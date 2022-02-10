using System;
using System.Collections.Generic;
using System.Text;

namespace pz__2._3
{
    class Package
    {
        public string nameDest;
        public string nameSor;
        public string addres;
        public string type;
        public DateTime receiptDate;

        public Package(string _nameDest, string _nameSor, string _addres, string _type)
        {
            nameDest = _nameDest;
            nameSor= _nameSor;
            addres = _addres;
            type = _type;
            receiptDate = new DateTime(2004,02,05,12,55,54);
        }

        public void GetPackageInfo()
        {
            Console.WriteLine($"nameDest = {nameDest}, nameSor = {nameSor}, addres = {addres}, receiptDate = {receiptDate}, type = {type}");
        }
    }
}
