using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("123456789", "James Gallgher", 2500);
            BankAccount acc2 = new BankAccount("987654321", "Rebbeca Jones", 4000);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine("\n");
            Console.WriteLine(acc2.GetAccountDetails());
            Console.WriteLine("\n");

            Console.WriteLine("Adding £1000 to acoount 1");
            acc1.Deposit(1000);
            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine("\n");

            Console.WriteLine("Withdrawing £500 to acoount 1");
            acc2.WithDraw(1000);
            Console.WriteLine(acc2.GetAccountDetails());

        }
    }
}
