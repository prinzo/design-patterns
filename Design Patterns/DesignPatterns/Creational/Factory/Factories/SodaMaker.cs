namespace DesignPatterns.Creational.Factory.Factories;

public class SodaMaker : IBeverageMaker
{
    public string MakeBeverage()
    {
        return "I just made a soda!";
    }
}