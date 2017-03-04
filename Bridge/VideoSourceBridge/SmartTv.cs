using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSourceBridge
{
    public class SmartTv : ISmartTv
    {
        public IVideoSource VideoSource { get; set; }

        public void PlayTv()
        {
            if (VideoSource != null)
            {
                VideoSource.PlayVideo();
            }
            else
            {
                Console.WriteLine("You should provide Video Source first.");
            }
        }

        public void ShowTvGuide()
        {
            if (VideoSource != null)
            {
                Console.WriteLine(VideoSource.GetTvGuide());
            }
            else
            {
                Console.WriteLine("You should provide Video Source first.");
            }
        }
    }
}
