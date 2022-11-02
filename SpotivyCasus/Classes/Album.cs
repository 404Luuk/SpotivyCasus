using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class Album : SongCollection
    {
        private List<Artist> artists;

        internal List<Artist> Artists { get => artists; set => artists = value; }

        public Album(List<Artist> albumArtists, string title, List<Song> songs) : base(title) 
        {
            Artists = albumArtists;
            songs.ForEach((song) =>
            {
                playables.Add(song);
            });
        }

        public List<Artist> ShowArtists() 
        {
            return Artists;
        }

        public override string ToString() 
        {
            string artistList = "";
            Artists.ForEach((A) => { artistList += A + " | "; });

            return Title + " || " + artistList;
        }
    }
}
