using System;
namespace _02UnderstandingTypes
{
	public class class14MostFrequentNumber
    {
		public class14MostFrequentNumber()
		{
			//Get the input array from the user
			Console.WriteLine("Please input the array(separate the elements with space:)");
			string input = Console.ReadLine();
			string[] parts = input.Split(' ');
			int[] array = new int[parts.Length];
			for(int i = 0; i < parts.Length; i++)
			{
				array[i] = int.Parse(parts[i]);
			}

			//Find the most frequent number
			Dictionary<int, int> table = new Dictionary<int, int>();

			int maxFrequency = 0;
			int mostFreqNum = 0;

			foreach(int num in array)
			{
				if (!table.ContainsKey(num))
				{
					table[num] = 0;
				}
				table[num]++;

				if (table[num] > maxFrequency) {
					maxFrequency = table[num];
					mostFreqNum = num;
				}

			}

			//Output the most frequency number
			Console.WriteLine($"The most frquency number in the input array is:");
			Console.WriteLine(mostFreqNum);
		}
	}
}

