using System;
namespace Interfaces
{
    interface ICar
    {
        public void Drive();
    }

    interface ITurbo
	{
        public void ActivateTurbo();
	}

    class Chevy : ICar, ITurbo
    {
        public void Drive()
        {
            Console.WriteLine("I'm a Chevy! And I'm driving!");
        }

        public void ActivateTurbo()
        {
            Console.WriteLine("Turbo has been activated on your Chevy!");
        }
    }

    class Ford : ICar, ITurbo
    {
        public void Drive()
        {
            Console.WriteLine("I'm a Ford! And I'm driving!");
        }

        public void ActivateTurbo()
		{
			Console.WriteLine("Turbo has been activated on your Ford!");
		}
    }

    class Kia : ICar
	{
        public void Drive()
		{
            Console.WriteLine("I'm a Kia! And I'm driving!");
        }
    }

    class Program
    {
        static void TestTrack(ICar thecar)
        {
            thecar.Drive();
        }

        static void TestTurbo(ITurbo theturbo)
		{
            theturbo.ActivateTurbo();
		}
        static void Main(string[] args)
        {
            Chevy trax = new Chevy();
            Ford escort = new Ford();
            Kia grapevan = new Kia();
            TestTrack(trax);
            TestTrack(escort);
            TestTrack(grapevan);
            TestTurbo(trax);
            TestTurbo(escort);
            //Not possible because Kia doesn't implement Turbo.
            //TestTurbo(grapevan);
        }
    }
}