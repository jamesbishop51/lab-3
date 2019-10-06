using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars c1 = new Cars();
            c1.Make = "Toyota";
            c1.Model = "corolla";
            c1.Engine = 1.7;
            c1.Speed = 0;

            Cars c2 = new Cars();
            c2.Make = "Ford";
            c2.Model = "Focus";
            c2.Engine = 1.1;
            c2.Speed = 0;

            c1.DisplayInfo();
            Console.WriteLine("\n");

            Console.WriteLine(c2);
            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine(c1);
        }
    }
}
