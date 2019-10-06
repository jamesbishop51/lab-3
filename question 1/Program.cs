using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars c1 = new Cars();
            c1.Make = "ford";
            c1.Model = "this one";
            c1.Speed = 0;
            c1.Engine = 1.6;

            Cars c2 = new Cars();
            c2.Make = "toyota";
            c2.Model = "pick up";
            c2.Speed = 0;
            c2.Engine = 2.1;


            Console.WriteLine($"make : {c1.Make} model : {c1.Model} Engine size : {c1.Engine} speed : {c1.Speed}");
            Console.WriteLine($"make : {c2.Make} model : {c2.Model} Engine size : {c2.Engine} speed : {c2.Speed}");

        }
    }
}
