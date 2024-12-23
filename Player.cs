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

        List<Item> items = new List<Item>();
        public Player()
        {

        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void UseItem()
        {
            foreach (Item item in items)
            {

                useItem = item;
                useItem.Use();
            }
        }

    }
}
