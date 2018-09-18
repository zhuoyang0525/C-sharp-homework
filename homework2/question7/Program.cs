using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question7
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 8, 9, 6, 5, 4, 7, 3 };
			int max;
			max = numbers[0];
			for(int i=1;i<=6;i++)
			{
				if(max<numbers[i])
				{
					max = numbers[i];
				}
			}
			System.Console.Write("数组中最大的数："+max+"\r\n");
			int min;
			min = numbers[0];
			for (int i = 1; i <= 6; i++)
			{
				if (min > numbers[i])
				{
					min = numbers[i];
				}
			}
			System.Console.Write("数组中最小的数："+min + "\r\n");
			int m = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6]) / 7;
			System.Console.Write("数组平均值：" + m + "\r\n");
			int n = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6]);
			System.Console.Write("数组之和：" + n + "\r\n");
		}
	}
}
