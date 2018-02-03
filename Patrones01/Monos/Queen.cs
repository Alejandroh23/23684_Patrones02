using System;
namespace Patrones01
{
    public class Queen : Caracter
    {
        public Queen(WeaponBehavior weapon)
        {
            base(weapon);
        }

        @Override
        public void fight()
        {
            Console.Write("Yo como reina ");
            base.fight();
        }
    }
}
