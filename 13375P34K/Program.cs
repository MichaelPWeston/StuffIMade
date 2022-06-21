using System.Collections.Generic;

public class Program
{
	public static string HackerSpeak(string str)
	{
		var characters = new Dictionary<string, string>()
		{
			{ "a", "4" },
			{ "e", "3" },
			{ "i", "1" },
			{ "o", "0" },
			{ "s", "5" },
			{ "t", "7" }
		};
		foreach (var chars in characters)
        {
			str = str.Replace(chars.Key, chars.Value );
        }
		return str;
		
	}

	static void Main()
    {
		string userString = Console.ReadLine();
		Console.WriteLine(HackerSpeak(userString));
    }
}