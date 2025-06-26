using AV.DesignPatterns.Strategy.Interfaces;

namespace AV.DesignPatterns.Strategy.Strategies;

public class MachineGunStrategy : IWeapon
{
    public void Shoot() => Console.WriteLine("Shoot with a machine gun");
}