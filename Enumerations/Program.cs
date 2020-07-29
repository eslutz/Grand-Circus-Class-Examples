using System;
using System.Collections.Generic;

namespace Enumerations
{
	enum Suit
	{
		Clubs,
		Diamonds,
		Hearts,
		Spades
	}

	enum Rank
	{
		Two = 2,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King,
		Ace
	}
	
	class Card
	{
		private static Random rand = new Random();
		public Suit suit { get; set; }
		public Rank rank { get; set; }

		public override string ToString()
		{
			int ordinal = (int)rank;
			if(ordinal <= 10)
			{
				return $"{ordinal} of {suit}";
			}
			else
			{
				return $"{rank} of {suit}";
			}
		}

		public static Card RandomCard()
		{
			int suitNum = rand.Next(Enum.GetValues(typeof(Suit)).Length);
			int rankNum = rand.Next(2, Enum.GetValues(typeof(Rank)).Length + 2);
			return new Card() { rank = (Rank)rankNum, suit = (Suit)suitNum };
		}
	}

	class Deck
	{
		public List<Card> Cards = new List<Card>();

		public Deck()
		{
			
		}

		public void Add(Card card)
		{
			Cards.Add(card);
		}

		public void FillDeck()
		{
			Cards.Clear();
			foreach(Suit s in Enum.GetValues(typeof(Suit)))
			{
				foreach (Rank r in Enum.GetValues(typeof(Rank)))
				{
					Cards.Add(new Card() { rank = r, suit = s });
				}
			}
			//for (int s = 0; s <= 3; s++)
			//{
			//	for (int r = 2; r <= 14; r++)
			//	{
			//		Cards.Add(new Card() { rank = (Rank)r, suit = (Suit)s});
			//	}
			//}
		}

		public void ListDeck()
		{
			foreach(Card card in Cards)
			{
				Console.WriteLine(card);
			}
		}

		public void Play()
		{
			if(Cards[0].rank < Cards[1].rank)
			{
				Console.WriteLine("The first is less than the second.");
			}
			else
			{
				Console.WriteLine("The first is greater than or equal to the second.");
			}
		}
	}

	enum GuitarStyle
	{
		acoustic,
		electric
	}

	class Guitar
	{
		public GuitarStyle Style { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			Guitar fender = new Guitar();
			fender.Style = GuitarStyle.electric;

			Guitar gibson = new Guitar();
			gibson.Style = GuitarStyle.acoustic;

			//Console.WriteLine(fender.Style);
			//Console.WriteLine(gibson.Style);

			Deck mydeck = new Deck();
			//Card first = new Card() { rank = Rank.Jack, suit = Suit.Diamonds };
			//Card second = new Card() { rank = Rank.Ten, suit = Suit.Diamonds };
			//mydeck.Add(first);
			//mydeck.Add(second);
			mydeck.FillDeck();
			mydeck.ListDeck();

			Console.WriteLine();
			for (int x = 0; x < 100; x++)
			{
				Console.WriteLine(Card.RandomCard());
			}
			Console.WriteLine();

			int size = Enum.GetValues(typeof(Suit)).Length;
			Console.WriteLine($"Suit size: {size}");
			Console.WriteLine($"Rank size: {Enum.GetValues(typeof(Rank)).Length}");
		}
	}
}
