using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11Iterator.itemIterator;

namespace _11Iterator.menu
{
    public class CafeMenu : Menu
    {
        Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            addItem("1号咖啡","这是第1号咖啡...",true,2.32);
            addItem("2号咖啡", "这是第2号咖啡...", true, 2.52);
            addItem("3号咖啡", "这是第3号咖啡...", true, 2.72);
            addItem("4号咖啡", "这是第4号咖啡...", true, 2.12);
            addItem("5号咖啡", "这是第5号咖啡...", true, 2.02);
        }

        public void addItem(string name,string description,bool vegetarian,double price)
        {
            MenuItem menuItem = new MenuItem(name,description,vegetarian,price);
            menuItems.Add(menuItem.Name,menuItem);
        }
        public Iterator createIterator()
        {
            return new CafeMenuIterator(menuItems);
        }
    }
}
