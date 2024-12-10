using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTestProject
{
	public class Fibonacci
	{
		public static int GetNthFibonacci(int n)
		{
			if (n <= 0)
				throw new ArgumentException("N must be a positive integer.");

			if (n == 1)
				return 0;  
			if (n == 2)
				return 1;  

			int a = 0, b = 1, c = 0;

			for (int i = 3; i <= n; i++)
			{
				c = a + b;
				a = b;
				b = c;
			}

			return c; 
		}
	}
}
