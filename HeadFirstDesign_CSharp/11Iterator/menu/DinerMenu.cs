using _11Iterator.itemIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Iterator
{
    //餐厅菜单
    public class DinerMenu : Menu
    {
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("餐厅菜1", "这是第1号餐厅菜...", true, 2.99);
            addItem("餐厅菜2", "这是第2号餐厅菜...", true, 2.99);
            addItem("餐厅菜3", "这是第3号餐厅菜...", true, 3.29);
            addItem("餐厅菜4", "这是第4号餐厅菜...", true, 3.05);
            //addItem("餐厅菜5", "这是第5号餐厅菜...", true, 3.25);
            //addItem("餐厅菜6", "这是第6号餐厅菜...", true, 3.65);
        }
        public void addItem(string name,string description,bool vegetarian,double  price)
        {
            MenuItem menuItem = new MenuItem(name,description,vegetarian,price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("不好意思，菜单已满。");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }

        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
