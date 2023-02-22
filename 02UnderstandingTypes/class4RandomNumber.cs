using System;
namespace _02UnderstandingTypes
{
    public class class4RandomNumber
    {
        public class4RandomNumber()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please guess the integer number between 1 and 3.");
            Console.WriteLine("Please give your guess: ");
            int input = int.Parse(Console.ReadLine());

            while (true)
            {
                if (input == correctNumber)
                {
                    Console.WriteLine("Congratulations! Your guess is correct!");
                    break;
                }
                else if (input > 3 && input < 1)
                {
                    Console.WriteLine("Out of range!");
                    Console.WriteLine("Please guess the integer number between 1 and 3.");
                    Console.WriteLine("Please give your guess: ");
                    input = int.Parse(Console.ReadLine());

                }
                else if (input < correctNumber)
                {
                    Console.WriteLine("Too low.");
                    Console.WriteLine("Please guess the integer number between 1 and 3.");
                    Console.WriteLine("Please give your guess: ");
                    input = int.Parse(Console.ReadLine());
                }
                else if (input > correctNumber)
                {
                    Console.WriteLine("Too high.");
                    Console.WriteLine("Please guess the integer number between 1 and 3.");
                    Console.WriteLine("Please give your guess: ");
                    input = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
