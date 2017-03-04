using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriverProxy
{
    class ProxyCar : ICar
    {
        private Driver driver;
        private ICar car;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.car = new Car();
        }

        public void DriveCar()
        {
            if (this.driver.Age < 18)
            {
                Console.WriteLine("The driver is bellow 18.");
            }
            else
            {
                this.car.DriveCar();
            }
        }
    }
}
