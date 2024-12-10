using Xunit;
using TDDTestProject;
namespace FibonnacciTests
{
	public class FibonnacciTests
	{
		[Theory]
		[InlineData(1, 0)]  
		[InlineData(2, 1)]  
		[InlineData(4, 2)]  
		[InlineData(10, 34)]
		public void GetNthFibonacci_ShouldReturnCorrectNumber(int n, int expected)
		{
			int result = Fibonacci.GetNthFibonacci(n);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(0)]  
		[InlineData(-1)] 
		public void GetNthFibonacci_WithInvalidInput_ShouldThrowArgumentException(int n)
		{
			var exception = Assert.Throws<ArgumentException>(() => Fibonacci.GetNthFibonacci(n));
			Assert.Equal("N must be a positive integer.", exception.Message);
		}

	}
}