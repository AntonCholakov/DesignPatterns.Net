using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsComposite
{
    public class Playlist : ISongComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ISongComponent> components { get; set; }

        public Playlist(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            components = new List<ISongComponent>();
        }

        public void Add(ISongComponent component)
        {
            components.Add(component);
        }

        public void Remove(ISongComponent component)
        {
            components.Remove(component);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Playlist: {0}, Description: {1}", this.Name, this.Description);

            foreach (ISongComponent component in components)
            {
                component.DisplayInfo();
            }
        }
    }
}
