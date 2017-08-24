package Factory.PizzaFactory;

import Factory.Pizza.CheesePizza;
import Factory.ingredient.PizzaType;
import Factory.ingredientFactory.CHPizzaIngredientFactory;
import Factory.interfaces.Pizza;
import Factory.interfaces.PizzaIngredientFactory;
import Factory.interfaces.PizzaStore;

//芝加哥工厂
public class ChicagoPizzaStore extends PizzaStore
{
    protected Pizza createPizza(PizzaType item)
    {
        Pizza pizza = null;
        PizzaIngredientFactory ingredientFactory = new CHPizzaIngredientFactory();
        if (item == PizzaType.cheese)
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.setName("Chicago Style Cheese Pizza");
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