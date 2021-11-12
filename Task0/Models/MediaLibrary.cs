using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task0.Models
{
    public class MediaLibrary
    {
        private List<Playlist> PlayLists { get; set; }
        private List<MediaFile> MediaFiles { get; set; }
        public MediaLibrary()
        {
            PlayLists = new List<Playlist>
            {
                new Playlist()
            };
            MediaFiles = new List<MediaFile>();
        }
        public void AddPlaylist(string name, List<MediaFile> mediaFiles)
        {
            Playlist playlist = new Playlist(name);
            playlist.AddMedia(mediaFiles);
            PlayLists.Add(playlist);
        }

        public void AddPlaylist(Playlist playlist)
        {
            PlayLists.Add(playlist);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            PlayLists.Remove(playlist);
        }

        public Playlist GetPlaylistByName(string name)
        {
            return PlayLists.FirstOrDefault(p => p.Name == name);
        }

        public void AddMediaToPlaylist(Playlist playlist, MediaFile mediaFile)
        {
            playlist.AddMedia(mediaFile);
        }

    }
}
