using System;
namespace _02UnderstandingTypes
{
	public class class8CountingUp
	{
		public class8CountingUp()
		{
			for(int i = 1; i <= 4; i++)
			{
				for(int j = 0; j < 24; j += i)
				{
					Console.Write($"{j},");
				}
                Console.WriteLine("24");
            }
		}
	}
}

