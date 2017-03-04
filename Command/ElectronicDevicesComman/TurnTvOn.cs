using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class TurnTvOn : ICommand
    {
        IElectronicDevice device;

        public TurnTvOn(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.On();
        }

        public void Undo()
        {
            this.device.Off();
        }
    }
}
