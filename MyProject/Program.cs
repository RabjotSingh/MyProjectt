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

        }
    }
}
