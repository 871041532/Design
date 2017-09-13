using _15Compound.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound
{
    class Program
    {
        //复合模式
        /*模式通常被一起使用，并被组合在同一个设计解决方案中。复合模式在一个解决方案中结合两个或多个模式以解决一般或重复发生的问题。
         * 
         * 采用模式时必须要考虑到这么做是否有意义，决不能为了使用模式而使用模式，有时候用好的OO设计原则就可以解决问题，这样其实就够了。
         * 
         * MVC模式是复合模式之王。
         */
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            simulator.simulate(new CountingDuckFactory());
            Console.ReadLine();
        }
    }
}
