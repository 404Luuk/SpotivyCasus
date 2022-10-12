using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class Album : SongCollection, iPlayable
    {
        private List<Artist> artists;

        public Album(List<Artist> albumArtists, string title, List<Song> songs) : base(title) 
        {
            artists = albumArtists;
            songs.ForEach((song) =>
            {
                playables.Add(song);
            });
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
