using System;

namespace calculator_challenge
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			Start:
			Random rnd = new Random();
			int num01 = rnd.Next(10);
			int num02 = rnd.Next(10);
			int ans = num01 * num02;
			int guess;
			tryAgain:
			Console.WriteLine ("What is " + num01 + " multiplied by " + num02 + "?");
			guess = Convert.ToInt32 (Console.ReadLine ());
			if (ans == guess) {
				Console.Write ("Well Done! That is the right answer!");
			} else {
				Console.Write ("You fucked up. Try again...\n");
				Console.WriteLine ();
				goto tryAgain;
			}
			Console.ReadKey ();
			Console.WriteLine ();
			goto Start;
		}
	}
}