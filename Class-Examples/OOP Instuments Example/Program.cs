using System;

namespace OOP_Instuments_Example
{
	class Instrument
	{
		public string Brand { get; set; }

		public Instrument(string brand)
		{
			Brand = brand;
		}

		public virtual void Describe()
		{
			Console.WriteLine($"You have an instrument from {Brand}.");
		}
	}

	class StringInstrument : Instrument
	{
		public int StringCount { get; set; }

		public StringInstrument(string brand, int stringCount) : base(brand)
		{
			StringCount = stringCount;
		}
		public override void Describe()
		{
			base.Describe();
			Console.WriteLine($"Your string instrument has {StringCount} strings.");
		}
	}

	class Synthesizer : Instrument
	{
		public int KeyCount { get; set; }

		public Synthesizer(string brand, int keyCount) : base(brand)
		{
			KeyCount = keyCount;		
		}
		public override void Describe()
		{
			base.Describe();
			Console.WriteLine($"Your synth had {KeyCount} keys.");
		}
	}

	class Guitar : StringInstrument
	{
		public string Style { get; set; }

		public Guitar(string brand, int stringCount, string style) : base(brand, stringCount)
		{
			Style = style;
		}
		public override void Describe()
		{
			base.Describe();
			Console.WriteLine($"You have an {Style} guitar.");
		}
	} 

	class Program
	{
		static void Main(string[] args)
		{
			Synthesizer synth1 = new Synthesizer("Korg", 61);
			synth1.Describe();
			Synthesizer synth2 = new Synthesizer("Roland", 88);
			synth2.Describe();
			Guitar guitar1 = new Guitar("Fender", 6, "electric");
			guitar1.Describe();
		}
	}
}