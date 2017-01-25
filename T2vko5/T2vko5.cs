using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class CeeDee
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        List<Song> song = new List<Song>();

        public List<Song> Song
        {
            get { return song; } 
        }

        public void AddSong(Song songName)
        {
            song.Add(songName);
        }

        public override string ToString()
        {
            return "Artist: " + Artist + "\nName: " + Name + "\nSongs:";
        }
    }

    class Song
    {
        public string SongName { get; set; }
        public string Duration { get; set; }

        public override string ToString()
        {
            return "\t- " + SongName + ", " + Duration;
        }
    }
}
