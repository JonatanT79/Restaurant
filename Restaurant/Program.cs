using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Start s = new Start();
            s.BeginProgram();

        }
    }
    class Start
    {
        public void BeginProgram()
        {
            Restaurant r = new Restaurant();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to restaurant Vegetarian Fresh");
            Console.WriteLine("Here is our digital menu:");
            Console.WriteLine("Press 1 to see the Menu sorted by cheapest price");
            Console.WriteLine("");
            Console.ResetColor();
            r.Menu();
            Console.WriteLine("Do you want to see the menu again? (This time SORTED by cheapest price)");
            string input = Console.ReadLine().ToUpper();

            while (input != "YES" && input != "NO")
            {
                Console.WriteLine("You must type an answer (YES/NO)");
                input = Console.ReadLine();
            }

            if (input == "YES")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Here is our SORTED menu:");
                Console.WriteLine("");
                Console.ResetColor();
                r.MenuPriceSorted();
                Console.WriteLine("Press 1 if you want to restart the application, otherwise, press any key to Exit");
                string restart = Console.ReadLine();

                if (restart == 1.ToString())
                {
                    Console.Clear();
                    BeginProgram();
                }
                else
                {
                    Console.WriteLine("Thanks for your time, Goodbye!");
                }
            }
            else
            {
                Console.WriteLine("Thanks for your time, Goodbye!");
            }
        }
    }
    class Restaurant
    {
        public List<Food> Foodlist = new List<Food>();
        public void Menu()
        {
            Food f1 = new Food();
            f1.ID = 1;
            f1.Name = "Deliciouscly homemade falafel";
            f1.Price = 147;

            Food f2 = new Food();
            f2.ID = 2;
            f2.Name = "Vegan hotdog";
            f2.Price = 30;

            Food f3 = new Food();
            f3.ID = 3;
            f3.Name = "Vegan pasta bolognese";
            f3.Price = 182;

            Food f4 = new Food();
            f4.ID = 4;
            f4.Name = "Vegan hamburger";
            f4.Price = 189;

            Food f5 = new Food();
            f5.ID = 5;
            f5.Name = "Vegan tacos";
            f5.Price = 239;

            Food f6 = new Food();
            f6.ID = 6;
            f6.Name = "Vegan special semla";
            f6.Price = 21;

            if(Foodlist.Count == 0)
            {
                Foodlist.Add(f1);
                Foodlist.Add(f2);
                Foodlist.Add(f3);
                Foodlist.Add(f4);
                Foodlist.Add(f5);
                Foodlist.Add(f6);
            }
            foreach (var item in Foodlist)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{"Name:",-30} {"Price"}");
                Console.ResetColor();
                Console.WriteLine($"{item.Name, -30} {item.Price} KR");
                LineDivide();
            }
        }
        public void MenuPriceSorted()
        {
            var query = from e in Foodlist
                        orderby e.Price
                        select e;

            foreach (var item in query)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{"Name:",-30} {"Price"}");
                Console.ResetColor();
                Console.WriteLine($"{item.Name,-30} {item.Price} KR");
                LineDivide();
            }
        }
        public void LineDivide()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

    }
    class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
