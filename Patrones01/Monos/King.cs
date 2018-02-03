using System;
namespace Patrones01
{
    public class King:Caracter {
        
    public King(WeaponBehavior weapon)
    {
        base(weapon);
    }

    @Override
    public void fight()
    {
            Console.Write("Yo como rey ");
        base.fight();
    }
}