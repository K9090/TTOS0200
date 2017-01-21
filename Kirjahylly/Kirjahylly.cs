using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class BookShelf
    {
        public string Name { get; set; }
        public string NumberOfRows { get; set; }
        public int NumberOfShelves { get; set; }
        public string Color { get; set; }


        public BookShelf()
        {
        }

        // constructor takes vehicle name and model as parameters
        public BookShelf(string name, string color)
        {
            Name = name;
            Color = color;
        }

        // return Vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + ", Color: " + Color + ", Number of shelves: " + NumberOfShelves + ", Number of rows: " + NumberOfRows;
        }
    }

    class DigitalMedia
    {
        public bool IsPhysical { get; set; }
        public float DataSize { get; set; }
        public string TypeOfMedia { get; set; } //ie CD, DVD, BluRay, Memory stick or card
        public string Name { get; set; } //If any


        public DigitalMedia()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public DigitalMedia(bool isPhysical, float dataSize, string typeOfMedia, string name)
        {
            IsPhysical = isPhysical;
            DataSize = dataSize;
            TypeOfMedia = typeOfMedia;
            Name = name;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + ", Is a physical media: " + IsPhysical + ", Size of media: " + DataSize + ", Type of media: " + TypeOfMedia;
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
