using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
	public enum Roshambo
	{
		Rock,
		Paper,
		Scissors
	}

	public enum Result
	{
		Draw,
		Player1,
		Player2,
		NoResult
	}
	public class RoshamboGame
	{
		public Result Play(Roshambo player1, Roshambo player2)
		{
			return (Result)((3 + (int)player1 - (int)player2) % 3);
		}
	}
}