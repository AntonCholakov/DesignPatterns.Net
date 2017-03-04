using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSourceBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv tv = new SmartTv();

            tv.VideoSource = new IPTvService();
            tv.ShowTvGuide();
            tv.PlayTv();

            tv.VideoSource = new LocalCableTv();
            tv.ShowTvGuide();
            tv.PlayTv();
        }
    }
}
