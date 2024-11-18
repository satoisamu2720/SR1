using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class FlyingRobot : Robot
    {
        public  FlyingRobot(string name) 
        {
            this.name = name;
        }

        public void DroBomb()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、爆弾を落とした!", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源offなので爆弾投下はつかえません..", name);
            }
        }
    }
}
