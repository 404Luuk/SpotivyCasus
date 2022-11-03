using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCasus.Classes
{
    internal class Person
    {
        private string name;
        private List<Person> friends = new List<Person>();
        protected List<Playlist> playlists = new List<Playlist>();

        public string Name { get => name; set => name = value; }
        internal List<Person> Friends { get => friends; set => friends = value; }
        internal List<Playlist> Playlists { get => playlists; set => playlists = value; }

        public Person(string name) 
        {
            Name = name;
        }
        
        //List of persons gets returned
        public List<Person> ShowFriendlist() 
        {
            return Friends;
        }

        //List of playlists gets returned
        public List<Playlist> ShowPlaylist() 
        {
            return Playlists;
        }

        //Playlist at playlists[index] gets returned
        public Playlist SelectPlaylist(int num) 
        {
            return Playlists[num];
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
