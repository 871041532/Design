package Factory.PizzaFactory;

import Factory.Pizza.CheesePizza;
import Factory.ingredient.PizzaType;
import Factory.ingredientFactory.NYPizzaIngredientFactory;
import Factory.interfaces.Pizza;
import Factory.interfaces.PizzaIngredientFactory;
import Factory.interfaces.PizzaStore;

//纽约工厂
public class NYPizzaStore extends PizzaStore
{
    @Override
    protected Pizza createPizza(PizzaType item)
    {
        Pizza pizza = null;
        PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        if (item == PizzaType.cheese)
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.setName("New York Style Cheese Pizza");
        } else if (item == PizzaType.veggie)
        {
            return null;
        } else if (item == PizzaType.clam)
        {
            return null;
        } else if (item == PizzaType.pepperoni)
        {
            return null;
        }
        return pizza;
    }
}