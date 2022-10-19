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
        protected List<iPlayable> playables;
        
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
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }
    }
}
