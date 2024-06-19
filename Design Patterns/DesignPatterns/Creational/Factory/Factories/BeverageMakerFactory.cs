using DesignPatterns.Creational.Factory.Enums;

namespace DesignPatterns.Creational.Factory.Factories;

public class BeverageMakerFactory
{
    public IBeverageMaker CreateBeverageMaker(BeverageType beverageType)
    {
        return beverageType switch
        {
            BeverageType.Coffee => new CoffeeMaker(),
            BeverageType.Tea => new TeaMaker(),
            BeverageType.Soda => new SodaMaker(),
            _ => throw new ArgumentOutOfRangeException(nameof(beverageType), beverageType, null)
        };
    }
}