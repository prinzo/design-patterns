namespace DesignPatterns.Creational.Factory.Factories;

public class CoffeeMaker : IBeverageMaker
{
    public string MakeBeverage()
    {
        return "I just made a coffee!";
    }
}