using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class TurnTvVolumeUp : ICommand
    {
        IElectronicDevice device;

        public TurnTvVolumeUp(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.VolumeUp();
        }

        public void Undo()
        {
            this.device.VolumeDown();
        }
    }
}
