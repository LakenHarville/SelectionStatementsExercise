using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess my favorite number.");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber == userInput)
            {
                Console.WriteLine("You got it!");
            }

            else if (favNumber > userInput)
            {
                Console.WriteLine("Too low!");
            }

            else if (favNumber < userInput)
            {
                Console.WriteLine("Too high!");
            }

            else
            {
                Console.WriteLine("Nevermind.");
            }

            
        }
    }
}
