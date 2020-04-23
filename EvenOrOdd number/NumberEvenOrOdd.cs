using System;
using NUnit;
using NUnit.Framework;

namespace EvenOrOdd_number
{
	[TestFixture]
	public class NumberEvenOrOdd
	{
		[TestCase("Even", 2)]//arrange
		[TestCase("Even", 0)]
		public void GivenNumber_NumberIsEven_ShouldReturnEven(string expected, int number)
		{
			//act
			var actual = EvenOrOdd_Number(number);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestCase("Odd", 1)]//arrange
		[TestCase("Odd", 7)]
		[TestCase("Odd",-1)]
		public void GivenNumber_NumberIsOdd_ShouldReturnOdd(string expected, int number)
		{
			//act
			var actual = EvenOrOdd_Number(number);
			//assert
			Assert.AreEqual(expected, actual);
		}

		private string EvenOrOdd_Number(int number)
		{
			/*if (number % 2 == 0)
				return "Even";
			return "Odd";*/
			return number % 2 == 0 ? "Even" : "Odd";
		}
	}
}
