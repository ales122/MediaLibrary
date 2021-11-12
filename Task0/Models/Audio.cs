using System;
using System.Collections.Generic;
using System.Text;

namespace Task0.Models
{
    public class Audio:MediaFile
    {
        public string Genre { get; set; }
        public string Singer { get; set; }

        public Audio
            (int id, string name, double size, string genre, string singer) : base(id, name, size)
        {
            Genre = genre;
            Singer = singer;
        }

        public override void InformationAboutMediaFile()
        {
            base.InformationAboutMediaFile();
            Console.WriteLine($"Genre:{Genre} - Singer:{Singer}");
        }
    }
}
