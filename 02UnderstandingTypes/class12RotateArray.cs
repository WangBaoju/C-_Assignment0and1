using System;
namespace _02UnderstandingTypes
{
	public class class12RotateArray
	{
		public class12RotateArray()
		{
            Console.WriteLine("Please the enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

			int[] input = new int[n];
			for(int i = 0; i < n; i++)
			{
                Console.WriteLine("Please the enter the integer in the array" +
					$"at index {i}:");
                int num = int.Parse(Console.ReadLine());
				input[i] = num;
            }

            Console.WriteLine("Please the enter the number of the rotations:");
            int k = int.Parse(Console.ReadLine());

           
			int[] sum = new int[n];

			for(int i = 1; i <= k; i++)
			{
				int temp = input[n - 1];

				for(int j = n-1; j >0; j--) {

					input[j] = input[j - 1];
					sum[j] += input[j];
				}
				input[0] = temp;
				sum[0] += input[0];
			}

			//The result of the sum array after the rotations
			Console.WriteLine($"The sum array after the {k} rounds of rotations:");
			foreach(int s in sum) {
				Console.Write(s + " ");
			}
        }
	}
}

