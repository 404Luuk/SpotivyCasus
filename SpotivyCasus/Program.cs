using System;
using SpotivyCasus.Classes;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            bool debug = false;

            if (debug) 
            {
                Artist luuk = new Artist("luuk");
                Artist bert = new Artist("bert");
                Artist niels = new Artist("niels");

                List<Artist> artists = new List<Artist>();

                artists.Add(luuk);
                artists.Add(bert);
                artists.Add(niels);

                Song song = new Song("Beat01", artists, 156, Genre.Rap);

                Console.WriteLine(song);
            }


        }

      
    }
}