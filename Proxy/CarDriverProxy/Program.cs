using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriverProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver john = new Driver("John", 17);
            Driver jack = new Driver("Jack", 25);
            ICar car = new Car();
            car.DriveCar();

            ICar proxyCar = new ProxyCar(john);
            proxyCar.DriveCar();
            john.Age++;
            proxyCar.DriveCar();

            proxyCar = new ProxyCar(jack);
            proxyCar.DriveCar();
        }
    }
}
