using DesignPatterns.Creational.Factory.Enums;

namespace DesignPatterns.Creational.Factory.Factories;

public class BeverageMakerFactory
{
    private readonly Dictionary<BeverageType, IBeverageMaker> _beverageMakers;

    public BeverageMakerFactory()
    {
        _beverageMakers = new Dictionary<BeverageType, IBeverageMaker>();
    }

    public void RegisterBeverageMaker(BeverageType beverageType, IBeverageMaker beverageMaker)
    {
        _beverageMakers[beverageType] = beverageMaker;
    }

    public IBeverageMaker GetBeverageMaker(BeverageType beverageType)
    {
        return _beverageMakers.TryGetValue(beverageType, out var beverageMaker) ? beverageMaker : new CoffeeMaker();
    }
}