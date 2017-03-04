using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSourceBridge
{
    public class LocalCableTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return "Getting TV Guide from Local Cable TV";
        }

        public void PlayVideo()
        {
            Console.WriteLine("Playing video from Local Cable TV");
        }
    }
}
