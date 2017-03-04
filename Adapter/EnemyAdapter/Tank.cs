using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyAdapter
{
    public class Tank : IEnemyAttacker
    {
        Random rand;

        public Tank()
        {
            rand = new Random();
        }

        public void AssignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank.");
        }

        public void DriveForward()
        {
            int spaces = rand.Next(1, 10);
            Console.WriteLine("Tank moved {0} spaces forward", spaces);
        }

        public void FireWeapon()
        {
            int damage = rand.Next(5, 100);
            Console.WriteLine("Tank damaged opponent with {0}", damage);
        }
    }
}
