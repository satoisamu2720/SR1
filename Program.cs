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
           Item item = new Item("つるはし");

            item.Use();

            Console.ReadLine();
        }
    }
}
