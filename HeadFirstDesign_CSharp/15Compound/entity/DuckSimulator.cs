using _15Compound.entity.composite;
using _15Compound.entity.observer;
using _15Compound.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity
{
    //鸭子模拟器
    public class DuckSimulator
    {
        public void simulate(AbstractDuckFactory duckFactory)
        {
            Quackable redheadDuck = duckFactory.createRedHeadDuck();
            Quackable duckCall = duckFactory.createDuckCall();
            Quackable rubberDuck = duckFactory.createRubberDuck();
            Quackable gooseDuck = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();
            flockOfDucks.add(redheadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(gooseDuck);

            Flock flockOfMallards = new Flock();
            Quackable mallardOne = duckFactory.createMallardDuck();
            Quackable mallardTwo = duckFactory.createMallardDuck();
            Quackable mallardThree = duckFactory.createMallardDuck();
            Quackable mallardFour = duckFactory.createMallardDuck();
            flockOfMallards.add(mallardOne);
            flockOfMallards.add(mallardTwo);
            flockOfMallards.add(mallardThree);
            flockOfMallards.add(mallardFour);

            flockOfDucks.add(flockOfMallards);


            //------------添加观察者相关内容--------------
            //观察者与主题：一对多，多对一。此处为一对多关系
            Quackologist quackologist = new Quackologist();
            flockOfDucks.registerObserver(quackologist);
            //------------------------------------------------
            Console.WriteLine("鸭子模拟器...\n");

            Console.WriteLine("\nflockOfDucks...");
            simulate(flockOfDucks);

            Console.WriteLine("\nflockOfMallards...");
            simulate(flockOfMallards);

            Console.WriteLine("\n鸭叫数："+QuackCounter.getQuacks());
        }
        private void simulate(Quackable duck)
        {
            duck.quack();
        }
    }
}
