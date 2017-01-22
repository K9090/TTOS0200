using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace T6JaT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 70;
            int height = 50;
            Console.SetWindowSize(width, height);
//---------------------------------------------------------------------------------
//T6
            Bookshelf bookshelf = new Bookshelf();
            bookshelf.Name = "IKEA, JätteMyckeHaaHaa";
            bookshelf.Color = "Black and white";
            bookshelf.Function = "Stores books and small items";
            bookshelf.NumberOfRows = 2;
            bookshelf.NumberOfShelves = 4;
            Console.WriteLine(bookshelf.ToString() + "\n");

            BluRay bluRayMovie = new BluRay();
            bluRayMovie.TypeOfData = "Movie";
            bluRayMovie.StorageSize = "25GB";
            bluRayMovie.IsBluray = true;
            bluRayMovie.Name = "Geteven";
            Console.WriteLine(bluRayMovie.ToString() + "\n");

            DVD dvdDoc = new DVD();
            dvdDoc.Name = "Tunturi";
            dvdDoc.IsDVD = true;
            dvdDoc.StorageSize = "4,7GB";
            dvdDoc.TypeOfData = "Documentary video";
            Console.WriteLine(dvdDoc.ToString() + "\n");

            CD musicCd = new CD();
            musicCd.Name = "Theme music for Geteven";
            musicCd.TypeOfData = "Music... barely";
            musicCd.StorageSize = "700mb";
            musicCd.IsCD = true;
            Console.WriteLine(musicCd.ToString() + "\n");

            Recreational fantasy = new Recreational();
            fantasy.Name = "Lord of the Rings";
            fantasy.Genre = "Fantasy";
            fantasy.PageNumber = 1000;
            fantasy.Thickness = 10;
            fantasy.TimesRead = 3;
            Console.WriteLine(fantasy.ToString() + "\n");

            Study math = new Study();
            math.Name = "Matematiikan Linkki";
            math.Genre = "Educational";
            math.PageNumber = 128;
            math.Thickness = 1;
            math.Level = "High school beginner";
            Console.WriteLine(math.ToString() + "\n");

//---------------------------------------------------------------------------------
//T7

            Bed singleBed = new Bed();
            singleBed.PersonCount = 1;
            singleBed.Function = "Sleeping unit";
            singleBed.Color = "White";
            singleBed.LegCount = 4;
            singleBed.Width = 100;
            Console.WriteLine(singleBed.ToString() + "\n");

            Bed orgyBed = new Bed();
            orgyBed.PersonCount = 4;
            orgyBed.Function = "XXX unit";
            orgyBed.Color = "Red";
            orgyBed.LegCount = 16;
            orgyBed.Width = 240;
            Console.WriteLine(orgyBed.ToString() + "\n");
        }
    }
}
