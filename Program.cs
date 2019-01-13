using System;

namespace MetanitEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController menu = new MenuController();
            bool again = true;
            while(again == true)
            {
                menu.MakeCalculation();

                Console.WriteLine("Do you want to repeat calculation?[y/n]");
                string answer = Console.ReadLine().ToUpper();
                again = (answer == "Y") ? again = true : again = false;
            }
        }
    }
}
