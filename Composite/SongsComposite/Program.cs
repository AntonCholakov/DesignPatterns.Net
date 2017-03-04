using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist topHits = new Playlist("Top Hits", "All Top Hits");
            Playlist popHits = new Playlist("Pop Hits", "All Pop Hits");
            Playlist rapHits = new Playlist("Rap Hits", "All Rap Hits");

            Playlist all = new Playlist("All", "All Hits");
            all.Add(topHits);
            all.Add(rapHits);

            topHits.Add(new Song("My top hit 1", "Performer 1", 2016));
            topHits.Add(new Song("My top hit 2", "Performer 1", 2017));
            topHits.Add(popHits);

            popHits.Add(new Song("My pop hit 1", "Pop perfomer 1", 2001));

            all.DisplayInfo();

        }
    }
}
