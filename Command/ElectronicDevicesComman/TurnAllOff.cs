using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class TurnAllOff : ICommand
    {
        List<IElectronicDevice> devices;

        public TurnAllOff(List<IElectronicDevice> devices)
        {
            this.devices = devices;
        }

        public void Execute()
        {
            foreach (IElectronicDevice device in devices)
            {
                device.Off();
            }
        }

        public void Undo()
        {
            foreach (IElectronicDevice device in devices)
            {
                device.On();
            }
        }
    }
}
