using _12Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Composite.entity
{
    public class Waitress
    {
        MenuComponent allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }
        public void printMenu()
        {
            allMenus.print();
        }
    }
}
