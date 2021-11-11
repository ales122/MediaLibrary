using System;
using System.Collections.Generic;
using System.Text;
using Task0.Interfaces;

namespace Task0.Models
{
    public abstract class MediaFile:IPlay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

        public MediaFile()
        {

        }

        public MediaFile(int Id, string Name, double Size)
        {
            this.Id = Id;
            this.Name = Name;
            this.Size = Size;
        }

        public abstract void InformationAboutMediaFile();
        public void Play()
        {
            InformationAboutMediaFile();
        }
    }
}
