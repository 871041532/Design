package Factory.interfaces;

import Factory.ingredient.Cheese;
import Factory.ingredient.Dough;
import Factory.ingredient.Sauce;

import java.util.ArrayList;

//比萨基类
public abstract class Pizza
{
    protected String name;
    protected Dough dough;//面团基类
    protected Sauce sauce;//酱料基类
    protected Cheese cheese;//起司奶酪基类
    protected ArrayList toppings = new ArrayList();//配料

    public abstract void prepare();//来自原料工厂的抽象类

    public void bake()
    {
        System.out.println("Bake for 25 miniutes at 350.");
    }
    //对角线切片
    public void cut()
    {
        System.out.println("Cutting the pizza into diagonal slices");
    }
    //包装
    public void box()
    {
        System.out.println("Place pizza in official PizzaStore box" + "\n");
    }

    public void setName(String _name)
    {
        name = _name;
    }

    public String getName()
    {
        return name;
    }

    public String toString()
    {
        return "这是一个" + name + "风格的披萨。";
    }
}