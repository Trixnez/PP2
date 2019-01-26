using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		class Student //create class
		{
			string name; //class items name, id, year
			string id;
			int year = 1;

			public Student(string name, string id) //constructor with input of 2 parameters,name and id
			{
				this.name = name; //assignment
				this.id = id;
			}

			public void print() //method to print class elements, name and id(access)
			{
				Console.WriteLine("Name of student: {0}", name);
				Console.WriteLine("Id of student: " + id);
				Console.WriteLine("Year of study: " + year);
			}

			public void incr() //method to increment year of study of student
			{
				year++;
				Console.WriteLine("Year of student increased by one, now is {0}", year);
			}
		}
		static void Main(string[] args)
		{
			Student s1 = new Student("Adilkhan", "18BD110399"); //create new object of class Student and assign values
			s1.print(); //call method print of class student
			s1.incr(); //call method incr of class student
		}
	}
}