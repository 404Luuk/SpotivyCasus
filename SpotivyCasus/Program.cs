using System;
using SpotivyCasus.Classes;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus 
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            /// Creating data to work with

            Person luuk = new Person("Luuk");
            Person robert = new Person("Robert");
            Person hendrik = new Person("Hendrik");

            Artist bob = new Artist("bob");
            Artist jim = new Artist("jim");
            Artist jesus = new Artist("jesus");
            Artist slimshady = new Artist("Marshall Maters");

            List<Artist> artists_one = new List<Artist>();
            List<Artist> artists_two = new List<Artist>();

            artists_one.Add(bob);
            artists_one.Add(jim);

            artists_two.Add(jesus);
            artists_two.Add(slimshady);

            Song eminem = new Song("eminem", artists_one, 155, Genre.Rap);
            Song raindrops = new Song("raindrops", artists_one, 188, Genre.urban);

            Song poland = new Song("poland", artists_two, 110, Genre.Rap);
            Song glitz = new Song("glitz", artists_two, 90, Genre.Pop);

            List<Song> songs1 = new List<Song>();
            List<Song> songs2 = new List<Song>();
            List<Song> allSongs = new List<Song>();

            songs1.Add(eminem);
            songs2.Add(raindrops);

            songs1.Add(poland);
            songs2.Add(glitz);

            allSongs.Add(eminem);
            allSongs.Add(raindrops);
            allSongs.Add(poland);
            allSongs.Add(glitz);

            Album album1 = new Album(artists_one, "album1", songs1);
            Album album2 = new Album(artists_two, "album2", songs2);

            List<Person> allUsers = new List<Person>();
            allUsers.Add(luuk);
            allUsers.Add(robert);
            allUsers.Add(hendrik);

            List<Album> allAlbums = new List<Album>();
            allAlbums.Add(album1);
            allAlbums.Add(album2);

            Client client = new Client(allUsers, allAlbums, allSongs);
            client.SetActiveUser(luuk);

           

            bool isRunning = true;
            while (isRunning) 
            {


            

            
            
            
            }
        }

     


    }
}