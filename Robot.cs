using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class Robot
    {
        protected string name;
       
        public Robot(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual void Attack()
        {
            Console.WriteLine("{0}は、攻撃した！", name);
        }

    }
}
