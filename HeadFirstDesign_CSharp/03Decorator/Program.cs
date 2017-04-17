using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*开闭原则：类应该对扩展开放，对修改关闭
 * 在选择需要被扩展的代码部分时要小心。
 * 每个地方都采用开闭原则是一种浪费，没必要，还会导致代码变得复杂且难以理解。
 */
/*装饰者模式：动态地将责任附加到对象上。
 * 若要扩展功能，装饰者提供了比继承更要弹性的替代方案。
 */
namespace _03Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Mocha mB = new Mocha(beverage);
            Whlp wB = new Whlp(mB);
            Console.WriteLine(wB.getDescription());
            Console.WriteLine(wB.cost());
            Console.ReadLine();
        }
    }
}
/*缺点：1.生成大量小类不容易理解 （Java I/O类）
 * 2.有些代码依赖特定类型，如果导入装饰者会导致异常
 * 3.使用时大量创建装饰者实例化组件，数量巨大。
 */