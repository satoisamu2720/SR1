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
        Item useItem;

        public Player(Item item)
        {
            useItem = item;
        }

        public void UseItem()
        {
            useItem.Use();
        }

    }
}
