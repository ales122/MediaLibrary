using System;
using Task0.Interfaces;
using Task0.Models;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.MediaLibrary.AddPlaylist(new Playlist("best"));
            mediaPlayer.Play(mediaPlayer.MediaLibrary.GetPlaylistByName("best"));
        }
    }
}
