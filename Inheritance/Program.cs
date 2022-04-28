using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //single level inheritance
    //class Vehicle //base class
    //{
    //    string number;
    //    string owner;
    //}
    //class Car : Vehicle //derived class
    //{
    //    int numberOfDoors;
    //}


    //multi level inheritance
    //class Vehicle //base class
    //{
    //    string number;
    //    string owner;
    //}
    //class FourWheeler : Vehicle //derived class
    //{
    //    int type;
    //}
    //class Car : FourWheeler //derived class
    //{
    //    int numberOfDoors;
    //}


    //hierarchical class
    class Vehicle //base class
    {
        public string Number { get; set; }
        public string Door { get; set; }

        public virtual void Start()
        {
            return;
        }
    }
    class FourWheeler : Vehicle //derived class
    {
        public string  VehicleType { get; set; }

        public override void Start()
        {
            Console.WriteLine("FourWheeler started");
        }
    }
    class Car:FourWheeler //derived class
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car started");
        }
    }
    class Tractor:FourWheeler //derived class
    {
        public int NumberOfAxles { get; set; }

        public override void Start()
        {
            Console.WriteLine("Tractor started");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

           // vehicles.Add(new FourWheeler());
            vehicles.Add(new Car());
            //vehicles.Add(new Tractor());



            foreach (var v in vehicles)
            {
                v.Start();
            }

            Console.ReadKey();
        }
    }
}
