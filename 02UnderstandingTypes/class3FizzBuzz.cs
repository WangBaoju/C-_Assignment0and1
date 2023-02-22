using System;
namespace _02UnderstandingTypes
{
	public class class3FizzBuzz
	{
		public class3FizzBuzz()
		{
            int max = 100;
            for (byte i = 0; i < max; i++)
            { 
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
            Console.WriteLine("The game is done !");

        }
	}
}

