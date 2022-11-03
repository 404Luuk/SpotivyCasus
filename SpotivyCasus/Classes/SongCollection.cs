using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class SongCollection : iPlayable
    {
        private string title;
        protected List<iPlayable> playables = new List<iPlayable>();

        public List<iPlayable> Playables { get => playables; }

        public string Title { get => title; set => title = value; }

        public SongCollection(string title) 
        {
            Title = title;
        }

        public override string ToString()
        {
            return title;
        }

        public List<iPlayable> ShowPlayables() 
        {
            return playables;
        }

        public void Play()
        {
            Playables.ForEach((playable) => { playable.Play(); });
        }

        public void Pause()
        {
            Console.WriteLine("list has been paused");
        }

        public void Stop()
        {
            Console.WriteLine("list has been stopped");
        }

        public void Next()
        {
            Console.WriteLine("playing next");
        }

        //Return total playlength of collection
        public int Length()
        {
            int total = 0;
            Playables.ForEach((p) => { total += p.Length(); });

            return total;
        }
    }
}
