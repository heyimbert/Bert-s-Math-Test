using System;
using System.Threading;

namespace Math_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bert's Math Test, press the 'Enter' key to continue.");
            Console.ReadLine();
            Console.WriteLine("Fantastic, let's start with some basic addition.");
            Thread.Sleep(1000);

            Random rand = new Random();
            int correct = 0;
            int max = 51;

            while (true)
            {
                int x = rand.Next(max);
                int y = rand.Next(max);

                Console.WriteLine($"What is {x} + {y}?");
                string userinput = Console.ReadLine();
                int answer = x + y;

                if (userinput == "")
                {
                    Console.WriteLine("You must enter a valid number");
                    continue;
                }
                
                if (answer == int.Parse(userinput))
                {
                    Console.WriteLine("Congratulations, that's correct!");
                    correct += 1;
                    if (correct % 10 == 0)
                    {
                        Console.WriteLine("Great work, now let's take it to the next level.");
                        max += 100;
                    }
                }
                else
                {
                    Console.WriteLine("You suck!");
                    break;
                }
            }

        }
    }
}
