using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class SongCollection
    {
        private string title;
        private List<iPlayable> playables;
        
        public string Title { get => title; set => title = value; }
        public List<iPlayable> Playables { get => playables; set => playables = value; }
    
        public SongCollection(string title) 
        {
            Title = title;
        }



        public override string ToString()
        {
            return title;
        }
    }
}
