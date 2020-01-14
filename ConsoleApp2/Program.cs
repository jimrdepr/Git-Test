using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 1;
            Console.WriteLine("Enter a starting number:");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a starting number:");
            int max = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int num = r.Next(min, max);

            Console.WriteLine("Hello World!");
            Console.WriteLine("I am thinking of a number between " + min + " and " + max);
            Console.WriteLine("Enter Guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != num)
            {
                tries++;

                if (guess > num)
                    Console.WriteLine("Too High");
                else
                    Console.WriteLine("Too Low");

                Console.WriteLine("Enter Guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Correct");
            Console.WriteLine("Guesses Made: " + tries);
        }
    }
}