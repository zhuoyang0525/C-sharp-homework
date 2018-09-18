using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question6
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			System.Console.Write("Please input a number:");
			n = int.Parse(Console.ReadLine());
			if (n <= 2)
			{
				System.Console.Write("null");
			}
			else
			{
				for (int c = 3; c <= n; c++)
				{
					for (int d = 2; d <= c; d++)
					{
						int e = c % d;
						if (e == 0)
						{
							if (d == c)
							{
								if (n % c == 0)
								{
									System.Console.Write(c + " ");
								}
							}
							else
							{
								break;
							}
						}
					}
				}
			}
		}
	}
}
