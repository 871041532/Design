using _11Iterator.itemIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Iterator
{
    //博饼屋菜单
   public class PancakeHouseMenu:Menu
    {
        ArrayList menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
            addItem("k&B's Pancake Breakfast","Pancakes with scrambled eggs,and toast",true,2.99);
            addItem("Regular Pancake Breakfast", "Pancakes with fried eggs,asusage", false, 2.99);
            addItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.49);
            addItem("Waffles", "Waffles, with your choice of blueberries or strawnerries", true, 3.59);
        }
        public void addItem(string name,string description,bool vegetarian,double price)
        {
            MenuItem menuItem = new MenuItem(name,description,vegetarian,price);
            menuItems.Add(menuItem);
        }
        
        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
