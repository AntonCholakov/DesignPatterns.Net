using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class TurnTvOff : ICommand
    {
        IElectronicDevice device;

        public TurnTvOff(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.Off();
        }

        public void Undo()
        {
            this.device.On();
        }
    }
}
