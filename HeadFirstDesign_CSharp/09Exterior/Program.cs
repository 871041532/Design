using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exterior
{
    class Program
    {
        /*
         外观模式定义
         外观模式提供了一个统一的接口，用来访问子系统中的一群接口
         外观定义了一个高层接口，让子系统更容易使用。
         */

        /*
         外观模式与适配器模式区别
         两种模式的差异，不在于它们包装了几个类，而在于它们的意图。
         适配器模式的意图是，“改变接口”符合客户的期望；而外观模式的意图是提供子系统的一个简化接口。
        */

        /*
         设计原则：最少知识原则
         只和你的密友谈话。
         这个原则希望我们在设计中，不要让太多的类耦合在一起，免得修改系统中一部分，会影响其他部分。如果许多类之间相互依赖，name这个系统就会变成一个易碎的系统，它需要花许多成本维护，也会因为太复杂而不容易被他人了解。
         在对象方法内，只应该调用以下方法：
         *该对象本身
         * 被当做方法的参数而传递进来的对象
         * 此方法创建或实例化的任何对象
         * 对象的任何组件
         不应该调用如下方法：
         *调用从另一个调用中返回的对象的方法。
         * 
         * 最少知识原则缺点：
         * 虽然此原则减少对象之间依赖，减少软件的维护成本。
         * 但是采用这个原则也会导致更多的“包装”类被制造出来，以处理和其他组件的沟通，这可能会导致复杂度和开发时间的增加，并降低运行时的性能。
         * 
         * MVC模式
         * 视图：用来呈现模型，视图
        */
        static void Main(string[] args)
        {
            HomeTherterFacade homeTheater = new HomeTherterFacade(new Amplifier(),new Tuner(),new DvdPlayer(),new Projector(),new TheaterLights(),new Screen(),new PopcornPopper());

            homeTheater.watchMovie("Raiders of the lost ark");
            Console.WriteLine();
            homeTheater.endMovie();
            Console.ReadLine();
        }
    }
}
