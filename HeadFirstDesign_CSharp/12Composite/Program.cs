using _12Composite.entity;
using _12Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Composite
{
    class Program
    {
        /*组合模式
         * 允许将对象组合成树形结构来表现“整体/部分”层次结构。组合能让客户以一致的方式处理个别对象以及对象组合。
         * 组合模式让我们能用树形方式创建对象的结构，树里面包含了组合以及个别的对象。
         * 使用组合结构，我们能把相同的操作应用在组合和个别对象上。换句话说，在大多数情况下，我们可以忽略对象组合和个别对象之间的差别。
         */
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("早餐菜单","这是一张早餐店...");
            MenuComponent dinerMenu = new Menu("食谱菜单","这是一张午餐菜单...");
            MenuComponent cafeMenu = new Menu("咖啡菜单", "这是一张咖啡菜单...");
            MenuComponent dessertMenu = new Menu("甜点菜单", "这是一张甜点菜单...");

            MenuComponent allMenus = new Menu("菜单总览","这是菜单总览...");
            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);
            
            //加入食谱
            dinerMenu.add(new MenuItem("食谱1","这是食谱1...",false,2.98));
            dinerMenu.add(dessertMenu);
            //加入甜点
            dessertMenu.add(new MenuItem("甜点1", "这是甜点1...", false, 3.2));
            //加入早餐
            pancakeHouseMenu.add(new MenuItem("早餐1", "这是早餐1...", false, 3.2));
            //加入咖啡
            cafeMenu.add(new MenuItem("咖啡1", "这是咖啡1...", false, 3.2));

            //侍者
            Waitress waitress = new Waitress(allMenus);
            waitress.printMenu();
            Console.ReadLine();
        }
    }
}
