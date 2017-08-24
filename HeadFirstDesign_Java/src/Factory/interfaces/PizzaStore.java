package Factory.interfaces;

import Factory.ingredient.PizzaType;

//抽象工厂
public abstract class PizzaStore
{
    public Pizza orderPizza(PizzaType type)
    {
        Pizza pizza;
        pizza = createPizza(type);
        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();
        return pizza;
    }
    protected abstract Pizza createPizza(PizzaType type);
}