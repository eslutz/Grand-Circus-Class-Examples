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
		public Suit suit { get; set; }
		public Rank rank { get; set; }
	}

	class Deck
	{
		public List<Card> Cards = new List<Card>();

		public Deck()
		{
			Card first = new Card() { rank = Rank.Two, suit = Suit.Clubs };
			Cards.Add(first);
			Card second = new Card() { rank = Rank.Ace, suit = Suit.Spades };
			Cards.Add(second);
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

			Console.WriteLine(fender.Style);
			Console.WriteLine(gibson.Style);

			Deck myDeck = new Deck();
			myDeck.Play();
		}
	}
}
