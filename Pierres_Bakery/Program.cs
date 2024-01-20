using Pierres_Bakery.Models;
using Pierres_Bakery.UserInterfaceModels;

namespace Pierres_Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Banners.Welcome);
            Console.WriteLine("Welcome to Pierre's Bakery!");
            PlaceOrder();
            static void PlaceOrder()
            {
                Console.WriteLine("How many loaves of sourdough would you like?");
                int sourdoughAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("How many loaves of focaccia would you like?");
                int focacciaAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("How many donuts would you like?");
                int donutAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("How many croissants would you like?");
                int croissantAmount = int.Parse(Console.ReadLine());

                Bread breadOrder = new(sourdoughAmount, focacciaAmount);
                Pastry pastryOrder = new(donutAmount, croissantAmount);

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

                    Console.WriteLine($"Your bread order come out to ${breadPrice} and your pastry order comes out to ${pastryPrice}.");
                    Console.WriteLine("This brings you to a grand total of...");
                    Console.WriteLine($"${breadPrice + pastryPrice}");
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

            static void Exit()
            {
                Console.WriteLine(Banners.Bye);
            }
        }
    }
}
