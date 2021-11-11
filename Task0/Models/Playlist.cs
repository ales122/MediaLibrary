using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task0.Interfaces;

namespace Task0.Models
{
    public class Playlist:IPlay
    {
        public string Name { get; set; }
        public List<MediaFile>MediaFiles { get; set; }

        public Playlist()
        {
            this.Name = "untitled";
            this.MediaFiles = new List<MediaFile>();
        }


        public void AllAboutMedia()
        {
            int i = 1;
            foreach (var item in MediaFiles)
            {
                System.Console.WriteLine(i + ". " + item.Name);
                i++;
            }
        }

        public MediaFile FindMedia(MediaFile media)
        {
            return MediaFiles.Find(x => x.Id == media.Id);
        }
        public void RemoveMedia(MediaFile mediaFile)
        {
            MediaFiles.Remove(mediaFile);
        }

        public void AddMedia(List<MediaFile> mediaFiles)
        {
            MediaFiles.AddRange(mediaFiles);
        }
        public void AddMedia(MediaFile mediaFile)
        {
            MediaFiles.Add(mediaFile);
        }

        public void Play()
        {
            Console.WriteLine("Playlist started...");
            for (int i = 0; i < MediaFiles.Count; i++)
            {
                Console.WriteLine($"The {i+1} media playing!");
            }
        }
    }
}
