using System;
namespace Patrones01
{
    public class Troll : Caracter
    {
        public Troll(WeaponBehavior weapon)
        {
            base(weapon);
        }

        @Override
    public void fight()
        {
            Console.Write("Yo como troll ");
            base.fight();
        }
    }
}