using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
        }

        // constructor takes vehicle name and model as parameters
        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        // return Vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Model year: " + ModelYear + ", Color: " + Color;
        }
    }

    class Bike : Vehicle
    {
        public bool HasGears { get; set; }
        public string GearModel { get; set; }

        public Bike()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Bike(string name, string model, bool hasGears, string gearModel)
            : base(name, model)
        {
            HasGears = hasGears;
            GearModel = gearModel;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + ", HasGears: " + HasGears + ", Gear Model: " + GearModel;
        }
    }

    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        public Boat()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Boat(string name, string model, string boatType, int seatCount)
            : base(name, model)
        {
            BoatType = boatType;
            SeatCount = seatCount;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + ", Boat type: " + BoatType + ", Seat count: " + SeatCount;
        }
    }
}
