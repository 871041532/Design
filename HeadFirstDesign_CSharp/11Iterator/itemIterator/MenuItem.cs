using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Iterator
{
    //菜单
    public class MenuItem
    {
        private string name;//名称
        private string description;//描述
        private bool vegetarian;//是否素食
        private double price;//价格

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public bool Vegetarian
        {
            get
            {
                return vegetarian;
            }

            set
            {
                vegetarian = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
