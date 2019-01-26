using System;

namespace project1
{
	class MainClass 
	{ 
		public static void Main (string[] args)
		{
			int n;
			string[] s = new string[256];
			int[] a = new int[100000];
			n = Convert.ToInt32 (Console.ReadLine ());
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < i +1; j++) {
					Console.Write("[*]");
				}
				Console.WriteLine();
			}

		}

	}
}