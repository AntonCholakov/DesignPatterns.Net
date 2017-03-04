using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyAdapter
{
    public class Robot
    {
        Random rand;

        public Robot()
        {
            rand = new Random();
        }

        public void SmashWithHands()
        {
            int damage = rand.Next(2, 8);
            Console.WriteLine("Robot damaged opponent with {0}", damage);
        }

        public void WalkForward()
        {
            int spaces = rand.Next(1, 2);
            Console.WriteLine("Robot walked {0} spaces forward", spaces);
        }

        public void ReactToHuman(string driverName)
        {
            Console.WriteLine("Robot slapped {0}", driverName);
        }
    }
}
