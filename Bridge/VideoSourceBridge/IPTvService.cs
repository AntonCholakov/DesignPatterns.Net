using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSourceBridge
{
    public class IPTvService : IVideoSource
    {
        public string GetTvGuide()
        {
            return "Getting TV Guide from IP TV";
        }

        public void PlayVideo()
        {
            Console.WriteLine("Playing video from IP TV");
        }
    }
}
