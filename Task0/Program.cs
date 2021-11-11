using System;
using Task0.Interfaces;
using Task0.Models;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {

            IPlay playlist = new Playlist();
            playlist.Play();
        }
    }
}
