using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class Radio : IElectronicDevice
    {
        private int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The Radio is Off.");
        }

        public void On()
        {
            Console.WriteLine("The Radio is On.");
        }

        public void VolumeDown()
        {
            this.Volume--;
            Console.WriteLine("The Radio volume is {0}", this.Volume);
        }

        public void VolumeUp()
        {
            this.Volume++;
            Console.WriteLine("The Radio volume is {0}", this.Volume);
        }
    }
}
