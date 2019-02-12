using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        static void Main()
        {
			FileStream fs = new FileStream(@"D:\adil\Week2\Task1\input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            if (palindrome(s) == true) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
		static bool palindrome(string s)
		{
			string s1 = new string(s.ToCharArray().Reverse().ToArray());
			if (s1 == s) return true;
			else return false;
		}
    }
}
