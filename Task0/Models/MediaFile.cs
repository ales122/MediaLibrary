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
        private double Size { get; set; }

        public MediaFile()
        {

        }

        public MediaFile(int id, string name, double size)
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
        }

        public  virtual void InformationAboutMediaFile()
        {
            Console.Write($"Name:{Name} - Size:{Size} - ");
        }
        public void Play()
        {
            InformationAboutMediaFile();
        }
    }
}
