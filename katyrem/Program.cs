using System;

delegate void MyDelegate();
//Голушко и Ибрагимов
namespace katyrem
{
    class Account
    {
        public double money;

        public void Plus(int a)
        {
            money += a;
        }
        public void Minus(int a)
        {
            money -= a;
        }
    }

    class Client
    {
        Account acc;

        public event MyDelegate eventt;

        public Client(Account a)
        {
            acc = a;
        }

        public void HowMoney()
        {
            if (acc.money < 10)
            {
                eventt += Message;
                eventt();
            }
            if (acc.money >= 10)
            {
                eventt -= Message;
                Console.WriteLine("деньги есть");
            }
        }

        private void Message()
        {
            Console.WriteLine("на вашем счету мало денег");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Client client = new Client(account);

            Console.WriteLine("_\nstart\n_");
            client.HowMoney();
            Console.WriteLine("_\nadd 10 money\n_");
            account.Plus(10);
            client.HowMoney();
            Console.WriteLine("_\nminus 1 money\n_");
            account.Minus(1);
            client.HowMoney();

        }
    }
}