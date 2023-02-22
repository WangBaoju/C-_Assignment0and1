using System;
namespace _02UnderstandingTypes
{
	public class class6Birthday
	{
		public class6Birthday()
		{
            Console.WriteLine("Please input the year of your birthday(example: 1990): ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the month of your birthday(Please " +
                "input 1-12 integer, for example: 2 for February): ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the day of your birthday(Please " +
                "input 1-31 integer): ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);
            TimeSpan age = DateTime.Now - birthDate;
            int ageInDays = (int)age.TotalDays;

            Console.WriteLine($"You are {ageInDays} days old now!");

            int daysToNextAnniversary = 10000 - (ageInDays % 10000);
            DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);

            Console.WriteLine($"Your next 10000 day anniversary is on {nextAnniversary:d}.");


        }
    }
}

