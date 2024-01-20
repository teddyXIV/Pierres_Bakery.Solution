using Pierres_Bakery.Models;
using Pierres_Bakery.UserInterfaceModels;

namespace Pierres_Bakery
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Banners.Welcome);
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("");
            Console.WriteLine("*~*~*~*~*~*~*~*   Menu   *~*~*~*~*~*~*~*~");
            Console.WriteLine("Sourdough Bread: $5 | Focaccia Bread: $4 ");
            Console.WriteLine("          Donut: $5 |      Croissant: $4 ");
            Console.WriteLine("This weeks specials are:");
            Console.WriteLine("Sourdough bread: Buy 2 Get 1 FREE!");
            Console.WriteLine("Focaccia bread: Buy 3 Get 1 75% OFF!");
            Console.WriteLine("Donuts: Buy 3 Get 1 FREE!");
            Console.WriteLine("Croissants: Buy 2 Get 1 50% OFF!");

            PlaceOrder();
            static void PlaceOrder()
            {
                Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
                Console.WriteLine("How many loaves of sourdough would you like?");
                string sourdoughString = Console.ReadLine();
                Console.WriteLine("How many loaves of focaccia would you like?");
                string focacciaString = Console.ReadLine();
                Console.WriteLine("How many donuts would you like?");
                string donutString = Console.ReadLine();
                Console.WriteLine("How many croissants would you like?");
                string croissantString = Console.ReadLine();

                try
                {
                    int sourdoughAmount = int.Parse(sourdoughString);
                    int focacciaAmount = int.Parse(focacciaString);
                    int donutAmount = int.Parse(donutString);
                    int croissantAmount = int.Parse(croissantString);
                    Bread breadOrder = new(sourdoughAmount, focacciaAmount);
                    Pastry pastryOrder = new(donutAmount, croissantAmount);

                    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
                    Console.WriteLine("Your have ordered the following:");
                    Console.WriteLine($"{breadOrder.SourdoughNum} loaves of sourdough.");
                    Console.WriteLine($"{breadOrder.FocacciaNum} loaves of focaccia.");
                    Console.WriteLine($"{pastryOrder.DonutNum} donuts.");
                    Console.WriteLine($"{pastryOrder.CroissantNum} croissants.");
                    Console.WriteLine("Does this look correct? (Type 'y' for yes, 'n' to correct your order, or press any other key to cancel your order.)");
                    string choice = Console.ReadLine();

                    if (choice.ToUpper() == "Y")
                    {
                        float breadPrice = Bread.CalculatePrice(breadOrder.SourdoughNum, 5, 3) + Bread.CalculatePrice(breadOrder.FocacciaNum, 4, 4, 0.75f);
                        float pastryPrice = Pastry.CalculatePrice(pastryOrder.DonutNum, 2, 4) + Pastry.CalculatePrice(pastryOrder.CroissantNum, 4, 3, 0.5f);

                        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~e");
                        Console.WriteLine($"Your bread order comes out to ${breadPrice} and your pastry order comes out to ${pastryPrice}.");
                        Console.WriteLine("This brings you to a grand total of...");
                        Console.WriteLine($"${breadPrice + pastryPrice}");
                        Exit();
                    }
                    else if (choice.ToUpper() == "N")
                    {
                        PlaceOrder();
                    }
                    else
                    {
                        Exit();
                    }
                }
                catch
                {
                    Console.WriteLine("Apologies, please only enter numbers for your orders.");
                    PlaceOrder();
                }
            }

            static void Exit()
            {
                Console.WriteLine(Banners.Bye);
            }
        }
    }
}
