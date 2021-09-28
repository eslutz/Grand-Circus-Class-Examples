using System;
using System.Collections.Generic;

namespace OOP
{
    class Car
    {
        // Member variables
        public string Make;
        protected string TireType;
        public string Owner;
        // Member functions
        public virtual void TuneUp()
        {
            Console.WriteLine("Ready for a tuneup!");
            Console.WriteLine($"While we're here we'll change the tires. You have {TireType}.");
        }
        public override string ToString()
        {
            return Make;
        }
    }
    class Chevrolet : Car
    {
        public Chevrolet(string theowner)
        {
            Owner = theowner;
            Make = "Chevrolet";
            TireType = "207-50-R16";
        }
        public override void TuneUp()
        {
            base.TuneUp();
            Console.WriteLine("The chevy is now tuned up.");
        }
    }
    class Honda : Car
    {
        public Honda(string theowner)
        {
            Owner = theowner;
            Make = "Honda";
            TireType = "209-60-R18";
        }
        public override void TuneUp()
        {
            base.TuneUp();
            Console.WriteLine("Thank you, the Honda is now good to go.");
        }
    }
    class Toyota : Car
    {
        public Toyota(string theowner)
        {
            Owner = theowner;
            Make = "Toyota";
            TireType = "205-80-R14";
        }
        public override void TuneUp()
        {
            base.TuneUp();
            Console.WriteLine("The Toyota is ready to go!");
        }
    }
    class JohnDeereTractor
    {
        void TuneUp() { }
    }
    class RepairShop
    {
        List<Car> bays = new List<Car>();
        public void Intake(Car thecar)
        {
            bays.Add(thecar);
        }
        public void CarRepair(Car thecar)
        {
            Console.WriteLine("Welcome to the repair shop!");
            thecar.TuneUp();
        }
        public void Stats(string Make)
        {
            Console.WriteLine($"Here are the stats on {Make}.");
            foreach (Car thecar in bays)
            {
                if (thecar.Make == Make)
                {
                    Console.WriteLine($"This is a {Make} owned by {thecar.Owner}.");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RepairShop sallyshop = new RepairShop();
            Chevrolet jeffcar = new Chevrolet("Jeff");
            Honda tiiacar = new Honda("Tiia");
            Toyota frankcar = new Toyota("Frank");
            Honda juliecar = new Honda("Julie");
            //Console.WriteLine(jeffcar.TireType);
            sallyshop.Intake(jeffcar);
            sallyshop.Intake(tiiacar);
            sallyshop.Intake(frankcar);
            sallyshop.Intake(juliecar);
            sallyshop.Stats("Toyota");
            sallyshop.CarRepair(jeffcar);
            sallyshop.CarRepair(tiiacar);
            sallyshop.CarRepair(frankcar);
        }
    }
}