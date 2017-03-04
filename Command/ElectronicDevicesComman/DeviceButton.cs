using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class DeviceButton
    {
        ICommand command;

        public DeviceButton(ICommand command)
        {
            this.command = command;
        }

        public void Press()
        {
            command.Execute();
        }

        public void PressUndo()
        {
            command.Undo();
        }
    }
}
