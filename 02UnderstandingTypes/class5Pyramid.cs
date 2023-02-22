using System;
namespace _02UnderstandingTypes
{
	public class class5Pyramid
	{
		public class5Pyramid()
		{
            Console.WriteLine("Please input the number of lines you want to print for the pyramid: ");
            int lines = int.Parse(Console.ReadLine());

			for(int i = 1; i <= lines; i++)
			{
				for(int j = 0; j < (2 * lines -1 -i); j++)
				{
					Console.Write(" ");
				}
				for(int k = 0; k < 2*i -1; k++)
				{
					Console.Write("*");
				}
                Console.WriteLine();
            }
        }
	}
}

