using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question9
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[201];
			int[] b = new int[200];
			int c = 0;
			int i, j;
			for (i = 2; i <= 200; i++) a[i] = i;
			for (i = 2; i < 200; i++)
				{
					for (j = i + i; j <= 200; j += i)
						a[j] = 0;
				}
			for(i=2;i<=200;i++)
			{
				if(a[i]!=0)
				{
					b[c] = a[i];
					c++;
				}
			}
			System.Console.Write("2~200之间的素数为：");
			for (i=0;i<c;i++)
			{
				System.Console.Write(b[i]+" ");
			}
		}
	}
}
