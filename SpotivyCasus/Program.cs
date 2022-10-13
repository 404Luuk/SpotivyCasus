using System;
using SpotivyCasus.Classes;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            bool debug = true;

            if (debug) 
            {
                Artist luuk = new Artist("Luuk");
                List<Artist> artists = new List<Artist>();
                artists.Add(luuk);

                Song one = new Song("one", artists, 133, Genre.urban);

                one.Play();
            }


        }

      
    }
}