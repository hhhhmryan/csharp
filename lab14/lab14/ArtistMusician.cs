using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    abstract class ArtistMusician
    {

        public string name { get; set; }

        public DateTime debut { get; set; }

        public ArtistMusician(string name)
        {
            this.name = name;
        }

        public ArtistMusician(string name, DateTime debut)
        {
            this.name = name;
            this.debut = debut;
        }

        public abstract void Info();

        public virtual void Discography()
        {
            Console.WriteLine("Empty");
        }

    }
}
