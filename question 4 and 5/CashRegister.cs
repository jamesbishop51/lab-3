using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4_and_5
{
    class CashRegister
    {

        public int NumberOfItems { get; private set; }

        public double Total { get; private set; }

        public static int TotalItemsAllCRs { get; set; }

        public static double TotalMoneyAllCRs { get; set; }
        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;

            TotalItemsAllCRs++;
            TotalMoneyAllCRs += itemPrice;
        }
    }
}
