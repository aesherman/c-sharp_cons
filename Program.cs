using System;

// using is like import

namespace Zazingo.Fitness
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                // Prompt user for minutes exercized
                Console.Write("Enter how many minutes you exercized or type \"quit\" to exit: ");
                string entry = Console.ReadLine(); 

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                int minutes = int.Parse(entry);
                
                // Add minutes exercized to total
                runningTotal = runningTotal + minutes;
                // Display total minutes exercized to the screen
                Console.WriteLine("You've exercized " + runningTotal + " minutes");
                }

                // Repeat until the user quits
            }

            Console.WriteLine("Goodbye");

        }
    }
}