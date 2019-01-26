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
			s = Console.ReadLine().Split();
			for (int i = 0; i < 2*n+1; i++) {
				a [i] = 0;
			}
			int j = 0;
			for (int i = 0; i < 2*n; i+=2) {

				a [i] = int.Parse (s [j]);
				a [i+1]= int.Parse (s [j]);
				j++;
			}
			for ( int i = 0; i < 2*n; i++) {
				Console.Write (a [i] + " ");

			}
		}

	}
}