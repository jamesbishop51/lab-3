using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1, lunch2, lunch3, lunch4, lunch5;

            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Entree = "Hamburger";
            lunch1.Sides = "Fries";
            lunch1.Drink = "Coke";

            lunch2.Entree = "Hot Dog";
            lunch2.Sides = "Chips";
            lunch2.Drink = "Fanta";

            lunch3.Entree = "Pizza";
            lunch3.Sides = "Salad";
            lunch3.Drink = "Water";

            lunch4.Entree = "Ham Sandwich";
            lunch4.Sides = "Fruit";
            lunch4.Drink = "Apple Juice";

            lunch5.Entree = "Cheese Toasties";
            lunch5.Sides = "Vegtables";
            lunch5.Drink = "Tropical Juice";

            Display(lunch1, lunch2, lunch3);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4, lunch5);
        }

        static void Display(params Lunch[] lunches)
        {
            Console.WriteLine("{0,-24}{1,-12}{2,-10}",
                "Entree", "Sides", "Drinks", "Colour", "Value");
            foreach (Lunch lunch in lunches)
            {
                Console.WriteLine("{0,-24}{1,-12}{2,-10}",
                lunch.Entree, lunch.Sides, lunch.Drink);
            }

        }
    }
    
}
