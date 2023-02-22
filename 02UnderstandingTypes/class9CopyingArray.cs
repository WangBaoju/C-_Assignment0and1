using System;
namespace _02UnderstandingTypes
{
	public class class9CopyingArray
	{
		public class9CopyingArray()
		{
			int[] array1 = { 2, 4, 6, 8, 10, 1, 3, 5, 7, 9 };
			int[] array2 = new int[array1.Length];

			for(int i = 0; i < array1.Length; i++)
			{
				array2[i] = array1[i];
			}

			Console.WriteLine("The array1 contains: ");
			foreach(int num in array1)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();
			Console.WriteLine("The array2 contains: ");
			foreach(int num in array2)
			{
				Console.Write(num + " ");
			}
		}
	}
}

