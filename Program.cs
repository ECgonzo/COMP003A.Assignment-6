/*
 * Author: Ethen Gonzalez
 * Course: COMP003A
 * Purpose: Replicate Output
 */

using System.Diagnostics;

namespace COMP003A.Assignment6
{
    internal interface IVehicle
    {
        void GetInfo();
    }

    abstract class Vehicle : IVehicle
    {
        private string _brand;
        private string _model;
        private int _numberOfWheels;

        public Vehicle() { }

        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }

    class Car : Vehicle
    {
        public Car(string brand, string model, int numberOfWheels) : base(brand, model, numberOfWheels) { }

        public override void GetInfo()
        {
            Console.WriteLine("I'm a Car");
            Console.WriteLine("I don't want to disclose my information.");
        }
    }

    class Truck : Vehicle
    {
        public Truck(string brand, string model, int numberOfWheels) : base(brand, model, numberOfWheels) { }

        public override void GetInfo()
        {
            Console.WriteLine("I'm a Truck");
            base.GetInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Supra", 4);
            Car car2 = new Car("Toyota", "Supra", 4);
            Truck truck1 = new Truck("GMC", "Sierra 1500 AT4", 6);
            Truck truck2 = new Truck("Ford", "F-150 Raptor", 4);

            Console.WriteLine("**********************************************************");
            Console.WriteLine("         vehicle1 Section\n");
            Console.WriteLine("**********************************************************");
            car1.GetInfo();
            Console.WriteLine();

            Console.WriteLine("**********************************************************");
            Console.WriteLine("         vehicle2 Section\n");
            Console.WriteLine("**********************************************************");
            car2.GetInfo();
            Console.WriteLine($"But you can still access my Properties.\n{car2.Brand} {car2.Model} {car2.NumberOfWheels}\n");

            Console.WriteLine("**********************************************************");
            Console.WriteLine("         vehicle3 Section\n");
            Console.WriteLine("**********************************************************");
            truck1.GetInfo();
            Console.WriteLine("I also have a 5.5 ft truck bed");

            Console.WriteLine("**********************************************************");
            Console.WriteLine("         vehicle4 Section\n");
            Console.WriteLine("**********************************************************");
            truck2.GetInfo();
            Console.WriteLine("I also have a 5.5 ft truck bed");
        }
    }
}