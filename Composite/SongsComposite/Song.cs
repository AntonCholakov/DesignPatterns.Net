using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsComposite
{
    public class Song : ISongComponent
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }

        public Song(string name, string author, int year)
        {
            this.Name = name;
            this.Author = author;
            this.ReleaseYear = year;
        }

        public void Add(ISongComponent component)
        {
            //Console.WriteLine("You cannot add to a song");
            throw new NotSupportedException();
        }

        public void Remove(ISongComponent component)
        {
            //Console.WriteLine("You cannot remove from a song");
            throw new NotSupportedException();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Song: {0}, Author: {1}, Year: {2}", this.Name, this.Author, this.ReleaseYear);
        }
    }
}
