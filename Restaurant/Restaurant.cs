using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    class Restaurant
    {
        public List<Food> Foodlist = new List<Food>();
        public void AddMealsToList()
        {
            //Add objects to list
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

            // Check if the object already exist, only add if list is empty
            if (Foodlist.Count == 0)
            {
                Foodlist.Add(f1);
                Foodlist.Add(f2);
                Foodlist.Add(f3);
                Foodlist.Add(f4);
                Foodlist.Add(f5);
                Foodlist.Add(f6);
            }
        }
        public void ShowMenu()
        {
            AddMealsToList();
            foreach (var item in Foodlist)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                // Function to make the output to be printed on same column
                Console.WriteLine($"{"Name:",-30} {"Price"}");
                Console.ResetColor();
                Console.WriteLine($"{item.Name, -30} {item.Price} KR");
                LineDivide();
            }
        }
        public void MenuPriceSorted()
        {
            AddMealsToList();

            // Using LINQ to sort Foodlist by price in ascending order (Cheapest price first)
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
        public void UserDecision()
        {
            Start s = new Start();
            Restaurant r = new Restaurant();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Do you want to see the menu again? (This time SORTED by cheapest price)");
            Console.ResetColor();
            string input = Console.ReadLine().ToUpper();

            //Error handling
            while (input != "YES" && input != "NO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must type an answer (YES/NO)");
                Console.ResetColor();
                input = Console.ReadLine().ToUpper();
            }

            if (input == "YES")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                // Call MenuPriceSorted that sorts the list with LINQ
                Console.WriteLine("Here is our SORTED menu: (Cheapest Meal first)");
                Console.WriteLine("");
                Console.ResetColor();
                r.MenuPriceSorted();

                //Restart program if answer is '1'
                Console.WriteLine("Press 1 if you want to restart the application, otherwise, press any key to Exit");
                string restart = Console.ReadLine();

                if (restart == 1.ToString())
                {
                    Console.Clear();
                    s.BeginProgram();
                }
                else
                {
                    //Exit Program
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine("Thanks for your time, Goodbye!");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("This application was made by Jonatan Tran (.NET Developer) - Student at Ithögskolan");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("Thanks for your time, Goodbye!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("This application was made by Jonatan Tran (.NET Developer) - Student at Ithögskolan");
                Console.ResetColor();
            }
        }
        public void LineDivide()
        {
            //Change color function + print the LineDivider
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
    }
}
