using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevicesComman
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            TurnTvOn onCommand = new TurnTvOn(tv);
            DeviceButton button = new DeviceButton(onCommand);
            button.Press();

            TurnTvOff offCommand = new TurnTvOff(tv);
            button = new DeviceButton(offCommand);
            button.Press();

            TurnTvVolumeUp volumeUpCommand = new TurnTvVolumeUp(tv);
            button = new DeviceButton(volumeUpCommand);
            button.Press();

            Television tv2 = new Television();
            Radio radio = new Radio();

            List<IElectronicDevice> devices = new List<IElectronicDevice>();
            devices.Add(tv2);
            devices.Add(radio);

            TurnAllOff turnOffDevicesCommand = new TurnAllOff(devices);
            DeviceButton turnOffButton = new DeviceButton(turnOffDevicesCommand);
            turnOffButton.Press();
            turnOffButton.PressUndo();
        }
    }
}
