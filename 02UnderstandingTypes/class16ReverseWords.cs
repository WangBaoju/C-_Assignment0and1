using System;
namespace _02UnderstandingTypes
{
	public class class16ReverseWords
	{
		public class16ReverseWords()
		{
            Console.WriteLine("Please input a string:");
            string words = Console.ReadLine();

            string[] wordsWithSeparators = words.Split(new char[] { ' ',',', '.',
                ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/',
                '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            string[] separatorsOnly = words.Split(wordsWithSeparators, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(wordsWithSeparators);

            string reversedWords = "";
            for(int i = 0; i < wordsWithSeparators.Length; i++)
            {
                reversedWords += wordsWithSeparators[i];

                if(i < separatorsOnly.Length)
                {
                    reversedWords += separatorsOnly[i];
                }
            }
            Console.WriteLine($"The separatoesOnly are: ");
            foreach(string s in separatorsOnly)
            {
                Console.Write(s + "|");
            }
            Console.WriteLine();

            Console.WriteLine($"The words with separators are: {wordsWithSeparators}");
            foreach (string s in wordsWithSeparators)
            {
                Console.Write(s + "|");
            }
            Console.WriteLine();
            Console.WriteLine($"The reversed words are: {reversedWords}");

        }
    }
}

