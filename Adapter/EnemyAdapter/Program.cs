using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.DriveForward();
            tank.FireWeapon();
            tank.AssignDriver("John");

            Console.WriteLine(new String('-', 10));

            Robot robot = new Robot();
            robot.WalkForward();
            robot.SmashWithHands();
            robot.ReactToHuman("Jack");

            Console.WriteLine(new String('-', 10));

            RobotAdapter robotAdapter = new RobotAdapter(robot);
            robotAdapter.DriveForward();
            robotAdapter.FireWeapon();
            robotAdapter.AssignDriver("Jack");
        }
    }
}
