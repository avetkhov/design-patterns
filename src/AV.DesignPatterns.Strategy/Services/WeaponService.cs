using AV.DesignPatterns.Strategy.Interfaces;

namespace AV.DesignPatterns.Strategy.Services;

public class WeaponService
{
    private IWeapon _weapon;

    public IWeapon SetWeapon(IWeapon weapon) => _weapon = weapon;

    public void Shoot() => _weapon.Shoot();
}