using _12Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Composite.entity
{
    public class MenuItem:MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name,string description,bool vegetarian,double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override void print()
        {
            Console.Write("名称："+name);
            if (isVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", "+price);
            Console.WriteLine("      -- "+description);
        }
        public override bool isVegetarian()
        {
            return vegetarian;
        }

    }
}
