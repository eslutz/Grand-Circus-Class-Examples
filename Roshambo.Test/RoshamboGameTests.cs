using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Roshambo.Test
{
	public class RoshamboGameTests
	{
		[Theory]
		[InlineData(Roshambo.Rock, Roshambo.Rock, Result.Draw)]
		[InlineData(Roshambo.Rock, Roshambo.Paper, Result.Player2)]
		[InlineData(Roshambo.Rock, Roshambo.Scissors, Result.Player1)]
		[InlineData(Roshambo.Paper, Roshambo.Rock, Result.Player1)]
		[InlineData(Roshambo.Paper, Roshambo.Paper, Result.Draw)]
		[InlineData(Roshambo.Paper, Roshambo.Scissors, Result.Player2)]
		[InlineData(Roshambo.Scissors, Roshambo.Rock, Result.Player2)]
		[InlineData(Roshambo.Scissors, Roshambo.Paper, Result.Player1)]
		[InlineData(Roshambo.Scissors, Roshambo.Scissors, Result.Draw)]
		public void TestAll(Roshambo player1, Roshambo player2, Result expeted)
		{
			RoshamboGame game = new RoshamboGame();
			Result res = game.Play(player1, player2);

			Assert.Equal(expeted, res);
		}

		//[Fact]
		//public void Test1()
		//{
		//	RoshamboGame game = new RoshamboGame();
		//	Result res = game.Play(Roshambo.Rock, Roshambo.Rock);

		//	Assert.Equal(Result.Draw, res);
		//}

		//[Fact]
		//public void Test2()
		//{
		//	RoshamboGame game = new RoshamboGame();
		//	Result res = game.Play(Roshambo.Paper, Roshambo.Paper);

		//	Assert.Equal(Result.Draw, res);
		//}
	}
}