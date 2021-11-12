using System;
using System.Collections.Generic;
using System.Text;

namespace Task0.Models
{
  public class Video:MediaFile
    {
        public double Duration { get; set; }
        public string Quality { get; set; }
        public Video(int id, string name, double size, double duration, string quality) : base(id, name, size)
        {
            this.Duration = duration;
            this.Quality = quality;
        }

        public override void InformationAboutMediaFile()
        {
            base.InformationAboutMediaFile();
            Console.WriteLine($"Duration:{Duration} - Quality:{Quality}");
        }
    }
}
