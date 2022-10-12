using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class Playlist : SongCollection
    {
        private Person owner;

        public Person Owner { get => owner; set => owner = value; }

        public Playlist(Person owner, string name) : base(name)
        {
            Owner = owner;
        }

        public void Add(iPlayable playable)
        {
            playables.Add(playable);
        }

        public void Remove(iPlayable playable) 
        {
            playables.Remove(playable);
        }

        public override string ToString()
        {
            return Title + " || " + Owner;
        }


    }
}
