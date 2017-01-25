using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T2vko5
{
    class Program
    {
        static void Main(string[] args)
        {
            CdInfo();
        }

        static void CdInfo()
        {
            // Create album
            CeeDee album = new CeeDee();
            album.Artist = "Nighwish";
            album.Name = "Endless Forms Most Beautiful";

            // Creates album's song list
            Song song = new Song();
            Song song1 = new Song { SongName = "Shudder Before the Beautiful", Duration = "6:29" };
            Song song2 = new Song { SongName = "Weak Fantasy", Duration = "5:23" };
            Song song3 = new Song { SongName = "Elan", Duration = "4:45" };
            Song song4 = new Song { SongName = "Yours Is an Empty Hope", Duration = "5:34" };
            Song song5 = new Song { SongName = "Our Decades in the Sun", Duration = "6:37" };
            Song song6 = new Song { SongName = "My Walden", Duration = "4:38" };
            Song song7 = new Song { SongName = "Endless Forms Most Beautiful", Duration = "5:07" };
            Song song8 = new Song { SongName = "Edema Ruh", Duration = "5:15" };
            Song song9 = new Song { SongName = "Alpenglow", Duration = "4:45" };
            Song song10 = new Song { SongName = "The Eyes of Sharbat Gula", Duration = "6:03" };
            Song song11 = new Song { SongName = "The Greatest Show on Earth", Duration = "24:00" };

            Console.WriteLine(album);

            album.AddSong(song1);
            album.AddSong(song2);
            album.AddSong(song3);
            album.AddSong(song4);
            album.AddSong(song5);
            album.AddSong(song6);
            album.AddSong(song7);
            album.AddSong(song8);
            album.AddSong(song9);
            album.AddSong(song10);
            album.AddSong(song11);

            foreach (Song s in album.Song)
            { 
                Console.WriteLine("{0}", s);
            }
            Console.WriteLine();
        }
    }
}
