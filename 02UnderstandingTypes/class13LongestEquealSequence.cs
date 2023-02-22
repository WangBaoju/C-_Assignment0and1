using System;
namespace _02UnderstandingTypes
{
	public class class13LongestEquealSequence
	{
		public class13LongestEquealSequence()
		{
            //Get the input array from the user
            Console.WriteLine("Please input the array(separate the elements with space:)");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = int.Parse(parts[i]);
            }


            //Find the length and most left index
            int maxLength = 0;
            int startIdx = 0;

            for(int i = 0; i < array.Length; i++) {
                int currLength = 1;
                while(i + currLength < array.Length &&
                    array[i+currLength] == array[i]) {
                    currLength++;
                }
                if(currLength > maxLength) {
                    maxLength = currLength;
                    startIdx = i;
                }
            }

            //Print out the results
            for(int i = 0; i < maxLength; i++) {
                Console.Write(array[startIdx] + " ");
            }
            Console.WriteLine();
        }
    }
}

