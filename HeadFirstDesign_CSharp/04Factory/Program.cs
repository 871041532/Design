using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            NYPizzaStore cStore = new NYPizzaStore();
            NYStyleCheesePizza np=cStore.orderPizza(PizzaType.cheese) as NYStyleCheesePizza;
            Console.ReadLine();
        }
    }
}
