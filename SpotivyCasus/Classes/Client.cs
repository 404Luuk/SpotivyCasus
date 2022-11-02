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
        protected iPlayable currentPlaying;
        private int       currentTime;
        private bool      playing;
        private bool      shuffle;
        private bool      repeat;
        protected SuperUser     activeUser;
        protected List<Album>   allAlbums = new List<Album>();
        protected List<Song>    allSongs = new List<Song>();
        protected List<Person>  allUsers = new List<Person>();

        public int CurrentTime { get => currentTime; set => currentTime = value; }
        public bool Playing { get => playing; set => playing = value; }
        public bool Shuffle { get => shuffle; set => shuffle = value; }
        public bool Repeat { get => repeat; set => repeat = value; }
        internal iPlayable CurrentPlaying { get => currentPlaying; set => currentPlaying = value; }
        internal SuperUser ActiveUser { get => activeUser;  }
        internal List<Album> AllAlbums { get => allAlbums;  }
        internal List<Song> AllSongs { get => allSongs;  }
        internal List<Person> AllUsers { get => allUsers; }
      

        public Client(List<Person> people, List<Album> albums, List<Song> songs) 
        {
            allAlbums = albums;
            allSongs = songs;
            allUsers = people;
            currentPlaying = allSongs[0];
        }

        // Take user given as parameter and sets it as ActiveUser
        public void SetActiveUser(Person user) 
        {
            var serializedParent = JsonConvert.SerializeObject(user);
            activeUser = JsonConvert.DeserializeObject<SuperUser>(serializedParent);
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
        => ActiveUser.ShowPlaylist().ForEach((list)=> { Console.WriteLine(list); });

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
            currentPlaying.Play();
        }

        public void Pause()
        {
            currentPlaying.Pause();
        }

        public void Stop()
        {
            currentPlaying.Stop();
        }

        public void Next()
        {
            currentPlaying.Next();
        }

        public int Length()
        {
            return currentPlaying.Length();
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
