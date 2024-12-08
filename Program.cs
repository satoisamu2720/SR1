using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---");

            List<Robot> robots = new List<Robot>();
            Random random = new Random(Environment.TickCount);

            for (int i = 0; i < 15; i++)
            {
                int r = random.Next(1, 1+1);
                if (r == 2) 
                { 
                    robots.Add(new TankRobot("タンク"));
                }

                if (r == 1)
                {
                    robots.Add(new FlyingRobot("爆撃機"));
                }
            }

            foreach (Robot robot in robots)
            {
                robot.Attack();
            }


            Console.ReadLine();
        }
    }
}
