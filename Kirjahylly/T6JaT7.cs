using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Furniture
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Function { get; set; }


        public Furniture()
        {
        }

        // constructor takes furniture name and model as parameters
        public Furniture(string name, string color, string function)
        {
            Name = name;
            Color = color;
            Function = function;
        }

        // return furniture data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + "\n\tColor: " + Color + "\n\tFunction: " + Function;
        }
    }

    class Bookshelf : Furniture
    {
        public int NumberOfRows { get; set; }
        public int NumberOfShelves { get; set; }


        public Bookshelf()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Bookshelf(int numberOfShelves, int numberOfRows, string name, string color, string function)
            : base(name, color, function)
        {
            NumberOfShelves = numberOfShelves;
            NumberOfRows = numberOfRows;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tNumber of shelves: " + NumberOfShelves + "\n\tNumber of rows: " + NumberOfRows;
        }
    }

    class Bed : Furniture
    {
        private int personCount;
        public int Width { get; set; } // in centimeters
        public int LegCount { get; set; }
        public int PersonCount {
            get { return personCount; }
            set
            {
                personCount = value;
                if (personCount == 1)
                {
                    Name = "Single Bed";
                }
                else if (personCount == 2)
                {
                    Name = "Double Bed";
                }
                else
                {
                    Name = "Orgy bed";
                }
            }
        }

        public Bed()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Bed(int width, int legCount, string name, string color, string function, int personCount)
            : base(name, color, function)
        {
            Width = width;
            LegCount = legCount;
            PersonCount = personCount;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tBed width: " + Width + "cm \n\tNumber of legs: " + LegCount;
        }
    }

    //---------------------------------------------------------------------------------------------------

    class Stuff
    {
        public string Name { get; set; } // If any

        public Stuff()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Stuff(string name)
        {
            Name = name;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return "Name of item: " + Name;
        }
    }

    class DigitalMedia : Stuff
    {
        public string StorageSize { get; set; }
        public string TypeOfData { get; set; } // Movie, music, programs, etc...

        public DigitalMedia()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public DigitalMedia(string storageSize, string typeOfData, string name)
         : base(name)
        {
            StorageSize = storageSize;
            TypeOfData = typeOfData;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tStorage size: " + StorageSize + "\n\tType of data: " + TypeOfData;
        }
    }
    class CD : DigitalMedia
    {
        public bool IsCD { get; set; }

        public CD()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public CD(string storageSize, string typeOfData, string name, bool isCD)
            : base(name, storageSize, typeOfData)
        {
            IsCD = isCD;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tIs a CD: " + IsCD;
        }
    }
    class DVD : DigitalMedia
    {
        public bool IsDVD { get; set; }

        public DVD()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public DVD(string storageSize, string typeOfData, string name, bool isDVD)
            : base(name, storageSize, typeOfData)
        {
            IsDVD = isDVD;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tIs a DVD: " + IsDVD;
        }
    }
    class BluRay : DigitalMedia
    {
        public bool IsBluray { get; set; }

        public BluRay()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public BluRay(string storageSize, string typeOfData, string name, bool isBluray)
            : base(name, storageSize, typeOfData)
        {
            IsBluray = isBluray;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tIs a Bluray: " + IsBluray;
        }
    }

    //----------------------------------------------------------------------------------

    class Book : Stuff
    {
        public string Genre { get; set; }
        public int PageNumber { get; set; }
        public int Thickness { get; set; } // In centimeters

        public Book()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Book(int thickness, int pageNumber, string genre, string name)
            : base(name)
        {
            Thickness = thickness;
            PageNumber = pageNumber;
            Genre = genre;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tGenre: " + Genre + "\n\tNumber of pages: " + PageNumber + "\n\tThickness of book: " + Thickness + "cm";
        }
    }

    class Study : Book
    {
        public string Level { get; set; }

        public Study()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Study(int thickness, int pageNumber, string genre, string name, string level)
            : base(thickness, pageNumber, genre, name)
        {
            Level = level;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tClass or difficulty level: " + Level;
        }
    }

    class Recreational : Book
    {
        public int TimesRead { get; set; }

        public Recreational()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Recreational(int thickness, int pageNumber, string genre, string name, int timesRead)
            : base(thickness, pageNumber, genre, name)
        {
            TimesRead = timesRead;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "\n\tRead " + TimesRead + " times";
        }
    }
}
