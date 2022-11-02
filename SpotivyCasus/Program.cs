using System;
using SpotivyCasus.Classes;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Creating data to work with ///
            
            //creating new users
            Person luuk = new("Luuk");
            Person robert = new("Robert");
            Person hendrik = new("Hendrik");

            //creating new artists
            Artist bob = new("bob");
            Artist jim = new("jim");
            Artist jesus = new("jesus");
            Artist slimshady = new("Marshall Maters");

            //creating lists or artists
            List<Artist> artists_one = new();
            List<Artist> artists_two = new();

            //adding artists to list
            artists_one.Add(bob);
            artists_one.Add(jim);

            artists_two.Add(jesus);
            artists_two.Add(slimshady);

            //creating new songs
            Song eminem = new("eminem", artists_one, 155, Genre.Rap);
            Song raindrops = new("raindrops", artists_one, 188, Genre.urban);

            Song poland = new("poland", artists_two, 110, Genre.Rap);
            Song glitz = new("glitz", artists_two, 90, Genre.Pop);

            //creating new lists for songs
            List<Song> songs1 = new();
            List<Song> songs2 = new();
            List<Song> allSongs = new();

            //adding songs to lists
            songs1.Add(eminem);
            songs2.Add(raindrops);

            songs1.Add(poland);
            songs2.Add(glitz);

            allSongs.Add(eminem);
            allSongs.Add(raindrops);
            allSongs.Add(poland);
            allSongs.Add(glitz);

            //creating new albums  
            Album album1 = new(artists_one, "album1", songs1);
            Album album2 = new(artists_two, "album2", songs2);

            //Creating new list of users
            List<Person> allUsers = new();
            allUsers.Add(luuk);
            allUsers.Add(robert);
            allUsers.Add(hendrik);

            //creating a new list of albums
            List<Album> allAlbums = new();
            allAlbums.Add(album1);
            allAlbums.Add(album2);

            //creating a new client with all the users, songs, and albums
            Client client = new(allUsers, allAlbums, allSongs);
            client.SetActiveUser(luuk);


            //  User story actions  //


            //User makes playlist
            client.CreatePlaylist("Rap");
            client.CreatePlaylist("Classical");
            client.CreatePlaylist("Modern");


            //User adds songs to playlist
            client.ActiveUser.AddToPlaylist(eminem, 0);
            client.ActiveUser.AddToPlaylist(raindrops, 0);

            //User removes song from playlist
            client.ActiveUser.RemoveFromPlaylist(raindrops, 0);

            //User has list and can view all owned playlists
            client.ShowPlaylists();

            //User can delete playlist
            client.ActiveUser.RemovePlaylist(2);

            //User can play a playlist
            client.ActiveUser.SelectPlaylist(0).Play();

            //User can play a selected song
            client.AllSongs[3].Play();

            //User can pause a song
            client.AllSongs[3].Pause();

            //User can add friends
            client.ActiveUser.AddFriend(robert);
            client.ActiveUser.AddFriend(hendrik);

            //User can view friendlist
            client.ShowFriends();

            //User can remove friend from list
            client.ActiveUser.RemoveFriend(hendrik); // :(

            //User can see song name, artist and length in a song
            client.AllSongs[1].Play();
        }
    } 
}