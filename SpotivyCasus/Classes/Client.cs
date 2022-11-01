using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class Client : iPlayable
    {
        private iPlayable currentPlaying;
        private int       currentTime;
        private bool      playing;
        private bool      shuffle;
        private bool      repeat;
        protected SuperUser     activeUser;
        private List<Album>   allAlbums;
        private List<Song>    allSongs;
        private List<Person>  allUsers;

        public int CurrentTime { get => currentTime; set => currentTime = value; }
        public bool Playing { get => playing; set => playing = value; }
        public bool Shuffle { get => shuffle; set => shuffle = value; }
        public bool Repeat { get => repeat; set => repeat = value; }
        internal iPlayable CurrentPlaying { get => currentPlaying; set => currentPlaying = value; }
        internal SuperUser ActiveUser { get => activeUser; set => activeUser = value; }
        internal List<Album> AllAlbums { get => allAlbums; set => allAlbums = value; }
        internal List<Song> AllSongs { get => allSongs; set => allSongs = value; }
        internal List<Person> AllUsers { get => allUsers; set => allUsers = value; }
      

        public Client(List<Person> people, List<Album> albums, List<Song> songs) 
        {
            AllAlbums = albums;
            AllSongs = songs;
            AllUsers = people;
        }

        // Take user given as parameter and sets it as ActiveUser
        public void SetActiveUser(Person user) 
        {
            var serializedParent = JsonConvert.SerializeObject(user);
            ActiveUser = JsonConvert.DeserializeObject<SuperUser>(serializedParent);
        }

        // Logs all albums in list
        public void ShowAllAlbums() 
        {
            Console.WriteLine("-- Albums -- ");
            AllAlbums.ForEach((album) =>
            {
                Console.WriteLine(album);
            });
        }

        // Logs all songs in list
        public void ShowAllSongs() 
        {
            Console.WriteLine("-- Songs -- ");
            AllSongs.ForEach((song) =>
            {
                Console.WriteLine(song);
            });
        }

        // Logs all users in list
        public void ShowAllUsers() 
        {
            Console.WriteLine("-- Users -- ");
            AllUsers.ForEach((user) =>
            {
                Console.WriteLine(user);
            });
        }

        //Show playlists of active user
        public void ShowUserPlaylists()
        => ActiveUser.ShowPlaylist();

        //
        public void SelectUserPlaylist(int index)
        => AllUsers[index].ShowPlaylist();

        public void SelectAlbum(int index) => Console.WriteLine(AllAlbums[index]);

        public void SelectSong(int index) => Console.WriteLine(AllSongs[index]);

        public void SelectUser(int index) => Console.WriteLine(AllUsers[index]);

    

        public void CreatePlaylist(string title) 
        => ActiveUser.CreatePlaylist(title);

        public void ShowPlaylists() 
        => ActiveUser.ShowPlaylist();

        public void SelectPlaylist(int index) 
        => ActiveUser.SelectPlaylist(index);

        public void RemovePlaylist(int index)
        => ActiveUser.RemovePlaylist(index);

        public void ShowFriends() 
        => ActiveUser.ShowFriendlist();


        public void SelectFriend() 
        {
            // todo
        }

        public void AddFriend(int index) 
        => ActiveUser.AddFriend(AllUsers[index]);

        public void RemoveFriend(int index) 
        => ActiveUser.RemoveFriend(AllUsers[index]);

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

        public void SetShuffle(bool val) 
        {
            Shuffle = val;
        }

        public void SetRepeat(bool val)
        {
            Repeat = val;
        }
    }
}
