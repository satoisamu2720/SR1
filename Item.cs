using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SR1
{
    internal class Item
    {
        protected string name;

        public Item(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public void Use()
        {
            Console.WriteLine("{0}を使った", name);
        }
    }
}
