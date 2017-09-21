﻿using System;
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
         * 视图：用来呈现模型。视图通常直接从模型中取得它需要显示的状态与数据。
         * 控制器：取得用户的输入并解读其对模型的意思。
         * 模型：模型持有所有的数据、状态和程序逻辑。模型没有注意到视图和控制器，虽然它提供了操纵和检索状态的接口，并发送状态改变通知给观察者。
         * 
         * MVC特点：
         * 你是用户-你和视图交互。
         * 控制器要求模型改变状态。
         * 控制器也可能要求视图做改变。
         * 当模型状态改变时，模型会通知视图。
         * 视图向模型询问状态。
         * 
         * （实例依赖JavaSwing库此处不写）
         * MVC模式使用的设计模式：
         * 策略：视图和控制器实现了经典的策略模式：视图是一个对象，可以被调整使用不同的策略，而控制器提供了策略。视图只关心系统中可视的部分，对于任何界面行为，都委托给控制器处理。使用策略模式也可以让视图和模型之间的关系解耦，因为控制器负责和模型交互来传递用户的请求。对于工作是怎么完成的，视图毫不知情。
         * 
         * 组合：视图本身实现了组合模式。显示包括了窗口、面板、按钮、文本标签等。每个显示组件如果不是组合节点，就是叶节点。当控制器告诉视图更新时，只需告诉视图最顶层的组件即可，组合会处理其余的事。
         * 
         * 观察者：模型实现了观察者模式，当状态改变时，相关对象将持续更新。使用观察者模式，可以让模型完全独立于视图和控制器。同一个模型可以使用不同的视图，甚至可以同时使用多个视图。
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
