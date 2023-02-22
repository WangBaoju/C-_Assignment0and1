using System;
namespace _02UnderstandingTypes
{
	public class class17Palindromes
	{
		public class17Palindromes()
		{
            Console.WriteLine("Please input a string:");
            string inputs = Console.ReadLine();

            string[] words = inputs.Split(new char[] { ' ', ',',
				'.', ':', ';', '=', '(', ')', '&', '[', ']', '"',
				'\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

			List<string> palindromes = new List<string>();
			foreach(string word in words)
			{
				if (isPalindrome(word)) {
					palindromes.Add(word);
				}

			}

			palindromes = palindromes.Distinct().ToList();
			palindromes.Sort();
			for(int i = 0; i < palindromes.Count-1; i++)
			{
				Console.Write(palindromes[i] + ", ");
			}
			Console.Write(palindromes[palindromes.Count - 1]);
			
        }
		static bool isPalindrome(string s)
		{
			for(int i = 0; i < s.Length/2; i++)
			{
				if (s[i]!= s[s.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}

