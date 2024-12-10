using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTestProject
{
	public class LeapYear
	{
		public static bool IsLeapYear(int year)
		{
			if (year % 400 == 0)
				return true;

			if (year % 4 != 0)
				return false;

			if (year % 100 == 0)
				return false;

			return true;
		}
	}
}
