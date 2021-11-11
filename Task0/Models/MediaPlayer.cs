using System;
using System.Collections.Generic;
using System.Text;
using Task0.Interfaces;

namespace Task0.Models
{
    public class MediaPlayer
    {
        public void Play(IPlay playable)
        {

            if (playable is Playlist)
            {
                (playable as Playlist).AllAboutMedia();
            }
            playable.Play();
        }



    }

}
