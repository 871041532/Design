using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11Iterator.itemIterator;
namespace _11Iterator
{
    public class Waitress
    {
        Menu pancakeHouseMenu;
        Menu dinerMenu;
        Menu cafeMenu;
        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu, Menu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }
        public void printMenu()
        {
            Console.WriteLine("---------以下是餐厅菜单---------");
            Iterator dinerIterator = dinerMenu.createIterator();
            printMenu(dinerIterator);

            Console.WriteLine("\n---------以下是早餐菜单---------");
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            printMenu(pancakeIterator);

            Console.WriteLine("\n---------以下是咖啡菜单---------");
            Iterator cafeIterator = cafeMenu.createIterator();
            printMenu(cafeIterator);
        }
        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem =iterator.next() as MenuItem;
                Console.WriteLine("名称:"+menuItem.Name+" 描述："+menuItem.Description+" 是否素食："+menuItem.Vegetarian+" 价格："+menuItem.Price);
            }
        }
    }
}
