using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class TankRobot : Robot
    {
        public TankRobot(string name) :base(name) 
        {
            this.name = name;
        }
        public override void Attack()
        {
           
            Console.WriteLine("{0}は、キャノン砲を撃った", name);
        }
    }
}
