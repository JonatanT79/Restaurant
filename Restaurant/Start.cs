using System;

namespace Restaurant
{
    class Start
    {
        public void BeginProgram()
        {
            Restaurant r = new Restaurant();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to restaurant Vegetarian Fresh");
            Console.WriteLine("Here is our digital menu:");
            Console.WriteLine("");
            Console.ResetColor();
            r.ShowMenu();
            r.UserDecision();
        }
    }
}
