using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyAdapter
{
    public interface IEnemyAttacker
    {
        void FireWeapon();
        void DriveForward();
        void AssignDriver(string driverName);
    }
}
