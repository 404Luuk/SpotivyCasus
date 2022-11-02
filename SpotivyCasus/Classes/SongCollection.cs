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
            playables[0].Play();
        }

        public void Pause()
        {
            playables[0].Pause();
        }

        public void Stop()
        {
            playables[0].Stop();
        }

        public void Next()
        {
            playables[0].Next();
        }

        public int Length()
        {
            int total = 0;
            Playables.ForEach((p) => { total += p.Length(); });

            return total;
        }
    }
}
