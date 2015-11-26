using System;

namespace calculator_challenge
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			Start:
			int num01;
			int num02;
			Console.Write ("Enter a number to be multiplied: ");

			num01 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter the number you want it to be multiplied with: ");
			num02 = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine (num01 + " multiplied by "+ num02 + " is " + (num01 * num02));
			Console.ReadKey ();
			Console.WriteLine ();
			goto Start;
		}
	}
}