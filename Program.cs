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

            List<int> numbers = new List<int>();
            Random random = new Random(Environment.TickCount);


            for (int i = 0; i < 10; i++)
            {
                int r = random.Next(-5,5+1);
                numbers.Add(r);
            }
            
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                
            }

            Console.ReadLine();

        }
    }
}
