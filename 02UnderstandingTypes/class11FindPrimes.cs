using System;
namespace _02UnderstandingTypes
{
	public class class11FindPrimes
	{
		public class11FindPrimes()
		{
			Console.WriteLine("Please the start integer numer:");
			int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please the end integer numer:");
            int end = int.Parse(Console.ReadLine());
			FindPrimesInRange(start, end);

			static int[] FindPrimesInRange(int start, int end)
			{
				List<int> res = new List<int>();

				for(int curr = start; curr<= end; curr++)
				{
					if (isPrime(curr)) {
						res.Add(curr);
					}
				}
				int[] primes = new int[res.Count];
				for(int i = 0; i < res.Count; i++)
				{
					primes[i] = res[i];
				}

				Console.WriteLine($"The primes between {start} and {end} are: ");
				foreach(int n in primes)
				{
					Console.Write(n + " ");
				}
				return primes;
			}
			static bool isPrime(int num)
			{
				if (num < 2) return false;
				for(int i = 2; i < Math.Sqrt(num); i++) {
					if(num % i == 0)
					{
						return false;
					}
				}
				return true;
			}
        }
	}
}

