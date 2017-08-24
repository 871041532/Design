package Decorator.inter;

//饮料抽象类
public abstract class Beverage
{
    protected String description="Unkown Beverage";
    public abstract double cost();
    public void setDescription(String description)
    {
        this.description = description;
    }

    public String getDescription()
    {

        return description;
    }
}
