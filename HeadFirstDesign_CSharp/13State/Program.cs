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
        /*状态模式允许对象在内部状态改变时改变它的行为，对象看起来好像修改了它的类。
         * 这个模式将状态封装成为独立的类，并将动作委托到代表当前状态的对象，行为会随着内部状态改变而改变。
         * 把状态模式看成是不用在context中放置许多条件判断的替代方案。而策略模式是除了继承之外的一种弹性替代方案。
         * 
         * 
         * State接口
         * State接口定义了一个所有状态的共同接口，任何状态都实现这个相同的接口，这样一来，状态转瞬之间可以互相替换。
         * 
         * Context（上下文）
         * Context是一个类，它可以拥有一些内部状态，在这个例子中GumballMachine就是这个Context。
         * 
         * state.handle()
         * 不管是在什么时候，只要又问调用Context的request()方法，它就会被委托到状态来处理。
         * 
         * ConcreteState（具体状态）
         * ConcreteState处理来自Context的请求。每一个ConcreteState都提供了它自己对于请求的实现。所以当Context改变状态时行为也跟着改变。
         * 
         * 一般来讲，当状态转换是固定的时候，就适合放在Context中；然后，当转换是更动态的时候，通常就会放在状态类中。将状态转换放在状态类中的缺点是：状态类之间产生了依赖。我们试图通过Context上的getter方法把依赖减到最小，而不是显式硬编码具体状态类。此举也决定了当系统进化时，究竟哪个类是对修改封闭的。
         * 
         */
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(3);
            Console.WriteLine(gumballMachine.toString());
            gumballMachine.turnCrank();
            gumballMachine.turnCrank();

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine.toString());

            gumballMachine.turnRefill();
            Console.WriteLine(gumballMachine.toString());
            Console.ReadLine();
        }
    }
}
