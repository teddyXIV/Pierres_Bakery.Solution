using System.Security.Cryptography.X509Certificates;
using Pierres_Bakery.Models;

namespace Pierres_Bakery
{
    class Program
    {
        static void Main()
        {
            int sourdoughAmount = 0;
            int focacciaAmount = 0;
            int ryeAmount = 0;


            Console.WriteLine("Welcome to Pierre's Bakery! Please take a moment to enter your order!");
            Console.WriteLine("Bread options:");
            Console.WriteLine("Type 'S' to enter how many sourdough loaves you'd like.");
            Console.WriteLine("Type 'F' to enter how many focaccia loaves you'd like.");
            Console.WriteLine("Type 'R' to enter how many Rye loaves you'd like.");
            Console.WriteLine("Pastry options:");
            Console.WriteLine("Type 'D' to enter how many donuts you'd like.");
            Console.WriteLine("Type 'C' to enter how many croissants you'd like.");
            Console.WriteLine("Type 'F' to enter how many fritters you'd like.");
            Console.WriteLine("Type 'done' to get your total");
            string choice = Console.ReadLine();
            if (choice == "S")
            {
                Console.WriteLine("How many sourdough loaves would you like?");
                sourdoughAmount = int.Parse(Console.ReadLine());
                Console.WriteLine($"You've ordered {sourdoughAmount} loaves of SourDough bread!");
            }
            else if (choice == "F")
            {
                Console.WriteLine("How many focaccia loaves would you like?");
                focacciaAmount = int.Parse(Console.ReadLine());
                PresentOptions();
            }
            else if (choice == "R")
            {
                Console.WriteLine("How many rye loaves would you like?");
                ryeAmount = int.Parse(Console.ReadLine());
                PresentOptions();
            }
            else if (choice == "D")
            {
                Console.WriteLine("How many donuts would you like?");
                string donutAmount = Console.ReadLine();
                PresentOptions();
            }
            else if (choice == "C")
            {
                Console.WriteLine("How many croissants would you like?");
                string croissantAmount = Console.ReadLine();
                PresentOptions();
            }
            else if (choice == "F")
            {
                Console.WriteLine("How many fritters would you like?");
                string fritterAmount = Console.ReadLine();
                PresentOptions();
            }
            else if (choice == "done")
            {

                Bread breadOrder = new(sourdoughAmount, focacciaAmount, ryeAmount);
                int sourdoughPrice = Bread.CalculatePrice(breadOrder.SourdoughNum, 5, 3);
                float focacciaPrice = Bread.CalculatePrice(breadOrder.FocacciaNum, 4, 4, 0.75f);
                int ryePrice = Bread.CalculatePrice(breadOrder.RyeNum, 4, 1);
                float breadTotal = sourdoughPrice + focacciaPrice + ryePrice;
                Console.WriteLine($"Your total is ${breadTotal}");
            }
            else
            {
                Console.WriteLine("Sorry, that option isn't available.");
                PresentOptions();
            }

        }

        // static void PresentOptions()
        // {
        //     Console.WriteLine("Bread options:");
        //     Console.WriteLine("Type 'S' to enter how may sourdough loaves you'd like.");
        //     Console.WriteLine("Type 'F' to enter how may focaccia loaves you'd like.");
        //     Console.WriteLine("Type 'R' to enter how may Rye loaves you'd like.");
        //     Console.WriteLine("Pastry options:");
        //     Console.WriteLine("Type 'D' to enter how may donuts you'd like.");
        //     Console.WriteLine("Type 'C' to enter how may croissants you'd like.");
        //     Console.WriteLine("Type 'F' to enter how may fritters you'd like.");
        //     Console.WriteLine("Type 'done' to get your total");
        // }

    }
}
