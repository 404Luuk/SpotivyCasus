using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    enum Genre 
    {
        Metal,
        Rock,
        urban,
        Rap,
        Classical,
        Pop,
    }

    class Song : iPlayable
    {
        private string title;
        private List<Artist> artists;
        private Genre songGenre;
        private int duration;

        public string Title { get => title; set => title = value; }
        public List<Artist> Artists { get => artists; set => artists = value; }
        public int Duration { get => duration; set => duration = value; }
        internal Genre SongGenre { get => songGenre; set => songGenre = value; }


        public Song(string title, List<Artist> artist, int duration, Genre genre) 
        {
            Title = title;
            Artists = artist;
            Duration = duration;
            SongGenre = genre;
        }

        //Shows songs name and title
        public override string ToString()
        {
            string AllArtists = "";
            int min = Duration / 60;
            int sec = Duration % 60; 

            Artists.ForEach((a) => { AllArtists += (a + " | "); });

            return Title + " || " + AllArtists + min + "." + sec;
        }

        public void Play()
        {
            Console.WriteLine("Currently playing: ");
            Console.WriteLine(this);
        }

        // Feature still in development
        public void Pause()
        => Console.WriteLine("- Song has been paused -");


        public void Stop()
        => Console.WriteLine("- Song has been stopped -");

        public void Next() => Play();

        // Returns duration of song
        public int Length() => Duration;
    }
}
