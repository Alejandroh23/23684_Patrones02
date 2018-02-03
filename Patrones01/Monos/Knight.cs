using System;
namespace Patrones01
{
    public class Knight:Caracter
    {
    public Knight(WeaponBehavior weapon)
    {
        base(weapon);
    }

    @Override
    public void fight()
    {
            Console.Write("Yo como caballero ");
        base.fight();
    }
}