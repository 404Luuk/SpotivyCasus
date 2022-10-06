using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCasus.Classes
{
    internal class Playlist
    {
        private Person _owner;
        private string playlistName;

        public Person Owner { get => _owner; set => _owner = value; }
        public string PlaylistName { get => playlistName; set => playlistName = value; }

        public Playlist(Person owner, string name) 
        {
            Owner = owner;
            PlaylistName = name;   
        }
    }
}
