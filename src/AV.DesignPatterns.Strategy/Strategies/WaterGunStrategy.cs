using AV.DesignPatterns.Strategy.Interfaces;

namespace AV.DesignPatterns.Strategy.Strategies;

public class WaterGunStrategy : IWeapon
{
    public void Shoot() => Console.WriteLine("Shoot with a water gun");
}