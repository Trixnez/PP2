using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
			FileStream fs = new FileStream(@"D:\adil\Week2\Task4\Task4\create.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine("Temir postavit mne full");
            sr.Close();
            fs.Close();
			File.Copy(@"D:\adil\Week2\Task4\Task4\create.txt", @"D:\adil\Week2\Task4\Task4\bin\Debug\create.txt");
            
			File.Delete(@"D:\adil\Week2\Task4\Task4\create.txt");



        }
    }
}
