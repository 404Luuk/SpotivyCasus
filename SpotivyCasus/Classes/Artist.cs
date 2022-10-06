using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCasus.Classes
{
    internal class Artist
    {
        private string name;
        private List<Album> albums;
        private List<Song> songs;

        public string Name { get => name; set => name = value; }
        public List<Album> Albums { get => albums; set => albums = value; }
        internal List<Song> Songs { get => songs; set => songs = value; }

        public Artist(string name)
        {
            Name = name;
        }

        public void AddSong(Song song) 
        {
            Songs.Add(song);
        }

        public void AddAlbum(Album album) 
        {
            Albums.Add(album);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
