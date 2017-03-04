using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSourceBridge
{
    public class LocalDishTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return "Getting TV Guide from Local Dish TV";
        }

        public void PlayVideo()
        {
            Console.WriteLine("Playing video from Local Dish TV");
        }
    }
}
