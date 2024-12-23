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


        List<Item> items;

        public Player()
        {
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void UseItem()
        {
            foreach (Item item in items)
            {
                item.Use();
            }
        }

    }
}
