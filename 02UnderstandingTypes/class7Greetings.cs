using System;
namespace _02UnderstandingTypes
{
	public class class7Greetings
	{
		public class7Greetings()
		{
			DateTime now = DateTime.Now;

			int currTimeHour = now.Hour;

			if(currTimeHour > 6 && currTimeHour < 12) {

				Console.WriteLine("Good Morning!");

			}else if (currTimeHour < 18)
			{
                Console.WriteLine("Good Afternoon!");

            }else if (currTimeHour < 24)
			{
                Console.WriteLine("Good Evening!");
			}
			else
			{
                Console.WriteLine("Good Night!");
            }

		}
	}
}

