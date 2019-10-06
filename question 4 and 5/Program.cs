using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4_and_5
{
    class Program
    {
        static void Main(string[] args)
        {

            CashRegister cr1 = new CashRegister();

            Console.WriteLine("Adding an item worth 7.50 to Cash Register 1");
            Console.WriteLine("Adding an item worth 5.00 to Cash Register 1");
            Console.WriteLine("Adding an item worth 2.50 to Cash Register 1");
            cr1.AddItem(7.50);
            cr1.AddItem(5.00);
            cr1.AddItem(2.50);
            Console.WriteLine("\n");

            CashRegister cr2 = new CashRegister();

            Console.WriteLine("Adding an item worth 17.50 to Cash Register 2");
            Console.WriteLine("Adding an item worth 15.00 to Cash Register 2");
            Console.WriteLine("Adding an item worth 22.50 to Cash Register 2");
            cr2.AddItem(17.50);
            cr2.AddItem(15.00);
            cr2.AddItem(22.50);
            Console.WriteLine("\n");

            Console.WriteLine("Cash Register CR1 Total: {0}", cr1.Total);
            Console.WriteLine("Cash Register CR1 Number Of Items: {0}", cr1.NumberOfItems);
            Console.WriteLine("\n");
            Console.WriteLine("Cash Register CR2 Total: {0}", cr2.Total);
            Console.WriteLine("Cash Register CR2 Number Of Items: {0}", cr2.NumberOfItems);
            Console.WriteLine("\n");

            Console.WriteLine("Total money of all cash registers: {0}", CashRegister.TotalMoneyAllCRs);
            Console.WriteLine("Total items of all cash registers: {0}", CashRegister.TotalItemsAllCRs);

        }
    }
}
