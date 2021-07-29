using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Class1 myobj = new Class1();
            int z = myobj.addition(5, 6);
            Console.WriteLine(z);

            Banking account = new Banking("Rabjot", 35000, 10000, 25000);
            account.TakeName();
            account.DepositMoney(1000);
            account.WithdrawMoney(25000);
            Console.WriteLine(account.balance);

        }
    }
}
