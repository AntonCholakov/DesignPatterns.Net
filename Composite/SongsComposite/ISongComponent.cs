using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsComposite
{
    public interface ISongComponent
    {
        void Add(ISongComponent component);
        void Remove(ISongComponent component);
        void DisplayInfo();
    }
}
