using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MathSystem.Tests
{
	public class ArithmeticTests
	{
		[Fact]
		public void Test1()
		{
			Arithmetic arit = new Arithmetic();

			int sum = arit.Add(2, 3);

			Assert.Equal(5, sum);
		}
	}
}
