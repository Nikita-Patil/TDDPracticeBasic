using TDDTestProject;
using Xunit;

namespace LeapYearTests
{
		public class LeapYearTests
		{
			[Theory]
			[InlineData(2020, true)]  
			[InlineData(2024, true)]  
			[InlineData(2000, true)] 
			public void IsLeapYear_ShouldReturnTrue_WhenYearDivisibleBy4(int year, bool expected)
			{
				bool result = LeapYear.IsLeapYear(year);

				Assert.Equal(expected, result);
			}

			[Theory]
			[InlineData(1900, false)] 
			[InlineData(2023, false)]
			public void IsLeapYear_ShouldReturnFalse_WhenYearNotDivisibleBy4(int year, bool expected)
			{
				bool result = LeapYear.IsLeapYear(year);
				Assert.Equal(expected, result);
			}

			[Theory]
			[InlineData(1900, false)]
			[InlineData(2100, false)]
			public void IsLeapYear_ShouldReturnFalse_WhenYearIsDivisibleBy4And100_ButNotBy400(int year, bool expected)
			{
				bool result = LeapYear.IsLeapYear(year);
				Assert.Equal(expected, result);
			}
			[Theory]
			[InlineData(2000, true)]
			[InlineData(1600, true)]
			public void IsLeapYear_ShouldReturnTrue_WhenYearIsDivisibleBy4And100_AlsoBy400(int year, bool expected)
			{
				bool result = LeapYear.IsLeapYear(year);
				Assert.Equal(expected, result);
			}
		}
}