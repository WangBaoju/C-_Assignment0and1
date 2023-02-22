using System;
namespace _02UnderstandingTypes
{
	public class class10ManageLists
	{
		public class10ManageLists()
		{
			List<String> myShoppingList = new List<string> {
				"apple",
				"banana",
				"milk",
				"cheese",
				"bacon",
				"spinach",
				"sweet corn"
			};

			while (true)
			{
				Console.WriteLine("The current list for today is:");
				foreach(String item in myShoppingList)
				{
                    Console.WriteLine("- " + item);
                }

				Console.Write("Please enter an operation(+item, -item or -- to clear):");
				string op = Console.ReadLine();

				if (op.StartsWith("+"))
				{
					string item = op.Substring(1).Trim();
					myShoppingList.Add(item);

				}else if (op.StartsWith("-"))
				{

					string item = op.Substring(1).Trim();
					if (item == "-")
					{
						myShoppingList.Clear();
					}
					else
					{
						myShoppingList.Remove(item);
					}
                }
				else if( op == "exit")
				{
					break;
				}
				else
				{
                    Console.WriteLine("Invalid operation.");

                }
            }

		}
	}
}

