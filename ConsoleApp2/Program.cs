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
            Random r = new Random();
            int num = r.Next(0, 100);

            Console.WriteLine("Hello World!");
            Console.WriteLine("I am thinking of a number between 0 and 100");
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