using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class Television : IElectronicDevice
    {
        private int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is Off.");
        }

        public void On()
        {
            Console.WriteLine("The TV is On.");
        }

        public void VolumeDown()
        {
            this.Volume--;
            Console.WriteLine("The TV volume is {0}", this.Volume);
        }

        public void VolumeUp()
        {
            this.Volume++;
            Console.WriteLine("The TV volume is {0}", this.Volume);
        }
    }
}
