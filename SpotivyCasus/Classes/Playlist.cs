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

        // Add playavle to playables list
        public void Add(iPlayable playable)
        {
            playables.Add(playable);
        }

        // Remove playable from list
        public void Remove(iPlayable playable)
        {
            if (playables.Contains(playable)) { playables.Remove(playable); }
            else { Console.WriteLine("Item does not exist in List<T>"); }
        }

        public override string ToString()
        {
            return Title + " | " + Owner;
        }


    }
}
