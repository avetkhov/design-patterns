using AV.DesignPatterns.Strategy.Services;
using AV.DesignPatterns.Strategy.Strategies;

namespace AV.DesignPatterns.Strategy;

public static class Program
{
    private static void Main()
    {
        var weapon = new WeaponService();
        
        weapon.SetWeapon(new MachineGunStrategy());
        weapon.Shoot();
        
        weapon.SetWeapon(new WaterGunStrategy());
        weapon.Shoot();
    }
}