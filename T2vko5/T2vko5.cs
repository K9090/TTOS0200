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

        public override string ToString()
        {
            return "Artist: " + Artist + "\nName: " + Name;
        }
    }

    class Song
    {
        public string SongName { get; set; }
        public float Duration { get; set; }

    }
}
