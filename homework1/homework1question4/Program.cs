using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "";
			double a = 0;
			double b = 0;
			Console.Write("Please input two numbers:");
			s = Console.ReadLine();
			a = Double.Parse(s);
			s = Console.ReadLine();
			b = Double.Parse(s);
			Console.WriteLine("The product of these numbers is:" + (a * b));

		}
	}
}