using System;
using System.Text;

class MainClass
{
	public static void Main (string[] args)
	{
		string w = "marron";
		StringBuilder sec = hide (w);
		while (String.Compare(sec.ToString (), w) != 0) {
			Console.WriteLine (sec);
			char c = ask_user ();
			sec = replace (sec, w, c);
		}
		Console.WriteLine (sec);
	}

	public static StringBuilder hide (string s)
	{
		StringBuilder res = new StringBuilder();
		foreach (char c in s)
			res.Append('*');
		return res;
	}

	public static StringBuilder replace (StringBuilder secret, string word, char letter)
	{
		var i = 0;
		foreach (char c in word) {
			if (c == letter)
				secret [i] = letter;
			i++;
		}
		return secret;
	}

	public static char ask_user()
	{
		Console.WriteLine ("Entrer une lettre: ");
		char l = Console.ReadLine () [0];
		return l;
	}
}
