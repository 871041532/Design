package Factory.Pizza;

import Factory.interfaces.Pizza;
import Factory.interfaces.PizzaIngredientFactory;

//起司披萨
public class CheesePizza extends Pizza
{
    PizzaIngredientFactory ingredientFactory;

    public CheesePizza(PizzaIngredientFactory _ingredientFactory)
    {
        ingredientFactory = _ingredientFactory;
    }
    @Override
    public void prepare()
    {
        System.out.println("Preparing " + name);
        dough = ingredientFactory.createDough();
        sauce = ingredientFactory.createSauce();
        cheese = ingredientFactory.createCheese();
    }
}