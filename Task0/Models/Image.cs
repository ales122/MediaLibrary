using System;
using System.Collections.Generic;
using System.Text;

namespace Task0.Models
{
    public class Image:MediaFile
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Image(int id, string name, double size, int height, int wight) : base(id, name, size)
        {
      
            this.Height = height;
            this.Width = wight;
        }


        public override void InformationAboutMediaFile()
        {
            Console.WriteLine($"Image with name - {Name}");
        }
    }
}
