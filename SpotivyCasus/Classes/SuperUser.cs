using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotivyCasus.Interfaces;

namespace SpotivyCasus.Classes
{
    internal class SuperUser : Person
    {
        public SuperUser(string name) : base(name) { }


        public void AddFriend(Person friend)
        {
            Friends.Add(friend);
            Console.WriteLine("Friend added: " + friend);
        }

        // Removes given person from users friendlist
        public void RemoveFriend(Person friend) 
        {
            if (Friends.Contains(friend)) 
            {
                Friends.Remove(friend);
                Console.WriteLine("Friend removed: " + friend);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        // Creates new playlist with title
        public Playlist CreatePlaylist(string title) 
        {
            Playlist playlist = new Playlist(this, title);
            Playlists.Add(playlist);

            Console.WriteLine("Playlist created: " + title);

            return playlist;
        }

        // Removes playlist from Playlists at index of num
        public void RemovePlaylist(int num) 
        {
            Console.WriteLine("Playlist removed: " + Playlists[num].Title);
            Playlists.Remove(Playlists[num]);
        }

        // Adds playable to playlist at the list index
        public void AddToPlaylist(iPlayable playable, int index) 
        {
            SelectPlaylist(index).Add(playable);
            Console.WriteLine("Added " + playable + " to playlist");
        }

        // Removes playable from playlist at list index
        public void RemoveFromPlaylist(iPlayable playable, int index) 
        {
            SelectPlaylist(index).Remove(playable);
            Console.WriteLine("Removed " + playable + " from playlist");
        }

    }
}
