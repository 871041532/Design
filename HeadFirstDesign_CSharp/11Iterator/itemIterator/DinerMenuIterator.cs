using _11Iterator.itemIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Iterator
{

    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position>=items.Length || items[position]==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position += 1;
            return menuItem;
        }
    }
}
