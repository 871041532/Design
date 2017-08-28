using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Iterator.itemIterator
{
   public class CafeMenuIterator : Iterator
    {
        Dictionary<string, MenuItem> cafeItems;
        string[] cafeNames;
        int position = 0;

        public CafeMenuIterator(Dictionary<string, MenuItem> cafeItems)
        {
            this.cafeItems = cafeItems;
            cafeNames = cafeItems.Keys.ToArray();
        }

        public bool hasNext()
        {
            if (position >= cafeNames.Length || cafeNames[position] == null)
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
            MenuItem menuItem = cafeItems[cafeNames[position]];
            position += 1;
            return menuItem;
        }
    }
}
