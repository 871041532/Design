using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Template
{
    public class Tea : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("添加柠檬...");
        }

        public override void brew()
        {
            Console.WriteLine("浸泡茶叶...");
        }
    }
}
