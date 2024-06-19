namespace DesignPatterns.Creational.Factory.Factories;

public class TeaMaker : IBeverageMaker
{
    public string MakeBeverage()
    {
        return "I just made a tea!";
    }
}