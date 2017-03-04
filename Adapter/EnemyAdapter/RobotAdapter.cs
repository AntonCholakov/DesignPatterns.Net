using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyAdapter
{
    public class RobotAdapter : IEnemyAttacker
    {
        private Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string driverName)
        {
            this.robot.ReactToHuman(driverName);
        }

        public void DriveForward()
        {
            this.robot.WalkForward();
        }

        public void FireWeapon()
        {
            this.robot.SmashWithHands();
        }
    }
}
