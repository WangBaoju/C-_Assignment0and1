using System;
namespace _02UnderstandingTypes
{
	public class class15ReverseString
	{
		public class15ReverseString()
		{
			Console.WriteLine("Please input a string:");
			string input = Console.ReadLine();

            Console.WriteLine("The input string is: " + input);
            //Method 1
            char[] charArray = input.ToCharArray();
			Array.Reverse(charArray);
			string output = new string(charArray);
			Console.WriteLine("Reversed string using method1: " + output);

            //Method2
            Console.WriteLine("Reversed string using method2: " + output);
            for (int i = input.Length -1; i >= 0; i--)
			{
				Console.Write(input[i]);
			}
		}
	}
}

