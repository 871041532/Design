package Factory.ingredientFactory;

import Factory.ingredient.*;
import Factory.interfaces.PizzaIngredientFactory;

//芝加哥原料工厂
public class CHPizzaIngredientFactory implements PizzaIngredientFactory
{
    @Override
    public Cheese createCheese()
    {
        return new Cheese();
    }
    @Override
    public Clams createClam()
    {
        return new Clams();
    }
    @Override
    public Dough createDough()
    {
        return new Dough();
    }
    @Override
    public Pepperoni createPepperoni()
    {
        return new Pepperoni();
    }
    @Override
    public Sauce createSauce()
    {
        return new Sauce();
    }
    @Override
    public Vegies[] createVeggies()
    {
        Vegies[] temp = new Vegies[3];
        temp[0]=new Vegies();
        temp[1]=new Vegies();
        temp[2]=new Vegies();
        return temp;
    }
}
