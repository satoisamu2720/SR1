using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class Player
    {
        Item item;

        public Player(Item item)
        {
            this.item = item;
        }

        public void UseItem()
        {
            Console.WriteLine("{0}", item);
            
        }

    }
}
