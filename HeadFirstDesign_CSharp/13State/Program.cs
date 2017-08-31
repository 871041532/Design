using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State
{
    class Program
    {
        //策略模式和状态模式是双胞胎，在出生时才分开。
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.ejectQuarter();
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.insertQuarter();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine.toString());

            Console.ReadLine();
        }
    }
}
